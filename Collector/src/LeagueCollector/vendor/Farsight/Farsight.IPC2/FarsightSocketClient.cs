using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Farsight.IPC2;

internal class FarsightSocketClient : IDisposable
{
	private ILogger<FarsightSocketClient> _logger;

	private ConnectionStatus _connectionStatus;

	private Task? _recTask;

	private Stream? _stream;

	private TcpClient? _tcpClient;

	private CancellationTokenSource? _cts;

	private const uint DEFAULT_REC_BUFFER_SIZE = 1048576u;

	private const uint DEFAULT_SEND_BUFFER_SIZE = 8192u;

	private const int LENGTH_PREFIX_SIZE = 4;

	private const int TRANSPORT_RETRY_DELAY_MS = 250;

	private const int MAX_MESSAGE_SIZE = 67108864;

	private byte[] _recbuf = new byte[1048576];

	private byte[] _sendbuf = new byte[8192];

	private readonly byte[] _lengthBuffer = new byte[4];

	private readonly SemaphoreSlim _sendLock = new SemaphoreSlim(1, 1);

	public ConnectionStatus ConnectionStatus
	{
		get
		{
			return _connectionStatus;
		}
		private set
		{
			if (_connectionStatus != value)
			{
				_connectionStatus = value;
				ConnectionStatusChanged?.Invoke(this, value);
			}
		}
	}

	public bool IsConnected => ConnectionStatus == ConnectionStatus.Connected;

	internal FarsightIpcTransport SelectedTransport { get; private set; }

	public short Port { get; set; }

	public bool PreferTcp { get; set; }

	public event EventHandler<ConnectionStatus>? ConnectionStatusChanged;

	public event EventHandler<ResponseEvent>? ResponseReceived;

	public FarsightSocketClient(ILogger<FarsightSocketClient>? logger = null)
	{
		_logger = logger ?? new NullLogger<FarsightSocketClient>();
		ConnectionStatus = ConnectionStatus.Disconnected;
	}

	internal async Task Connect(int expectedServerProcessId, int expectedServerSessionId, string host = "127.0.0.1", short port = 4998, CancellationTokenSource? cts = null)
	{
		ConnectionStatus connectionStatus = ConnectionStatus;
		if ((uint)(connectionStatus - 1) <= 1u)
		{
			return;
		}
		ConnectionStatus = ConnectionStatus.Connecting;
		if (port == 0)
		{
			port = 4998;
		}
		Port = port;
		_cts = ((cts == null) ? new CancellationTokenSource() : CancellationTokenSource.CreateLinkedTokenSource(cts.Token));
		CancellationToken cancellationToken = _cts.Token;
		FarsightServerIdentity server = new FarsightServerIdentity(expectedServerProcessId, expectedServerSessionId);
		try
		{
			bool loggedFallback = false;
			while (!cancellationToken.IsCancellationRequested)
			{
				server.EnsureLive();
				var (namedPipeClientStream, namedPipeConnectFailure) = PreferTcp
					? ((System.IO.Pipes.NamedPipeClientStream?)null, (NamedPipeConnectFailure?)NamedPipeConnectFailure.Unsupported)
					: await NamedPipeTransport.TryConnectAsync(server, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (namedPipeClientStream != null)
				{
					ActivateTransport(namedPipeClientStream, null, FarsightIpcTransport.NamedPipe);
					return;
				}
				if (!TcpTransport.IsServerPortBound(server, (ushort)Port))
				{
					await Task.Delay(250, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					continue;
				}
				if (!loggedFallback)
				{
					_logger.LogInformation("IPC2 - Named pipe {FallbackReason} for League PID {ProcessId}; falling back to verified legacy TCP", namedPipeConnectFailure, expectedServerProcessId);
					loggedFallback = true;
				}
				try
				{
					TcpClient tcpClient = await TcpTransport.ConnectAsync(server, host, Port, 1048576, 8192, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ActivateTransport(tcpClient.GetStream(), tcpClient, FarsightIpcTransport.Tcp);
					return;
				}
				catch (SocketException)
				{
					await Task.Delay(250, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			cancellationToken.ThrowIfCancellationRequested();
		}
		catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
		{
			ResetConnectionResources();
			ConnectionStatus = ConnectionStatus.Disconnected;
		}
		catch (Exception exception)
		{
			ResetConnectionResources();
			_logger.LogError(exception, "IPC2 - Refusing connection to League PID {ProcessId} after transport verification failed", expectedServerProcessId);
			ConnectionStatus = ConnectionStatus.Error;
		}
	}

	internal static bool IsExpectedServerAvailable(int processId, int sessionId, short port)
	{
		FarsightServerIdentity server = new FarsightServerIdentity(processId, sessionId);
		if (!server.IsLive())
		{
			return false;
		}
		if (!NamedPipeTransport.ProbeExists(server))
		{
			return TcpTransport.IsServerPortBound(server, (ushort)port);
		}
		return true;
	}

	private void ActivateTransport(Stream stream, TcpClient? tcpClient, FarsightIpcTransport transport)
	{
		_stream = stream;
		_tcpClient = tcpClient;
		SelectedTransport = transport;
		_recTask = ReceiveData();
		_logger.LogInformation("IPC2 - Connected using {Transport}", transport);
		ConnectionStatus = ConnectionStatus.Connected;
	}

	private void ResetConnectionResources()
	{
		_stream?.Dispose();
		_stream = null;
		_tcpClient?.Dispose();
		_tcpClient = null;
		_cts?.Dispose();
		_cts = null;
		SelectedTransport = FarsightIpcTransport.None;
	}

	public void EnableLogging(ILogger<FarsightSocketClient> logger)
	{
		_logger = logger;
	}

	public void DisableLogging()
	{
		_logger = new NullLogger<FarsightSocketClient>();
	}

	public async Task<Response?> SendAndWaitForResponse(Request r, CancellationTokenSource? cts = null, TimeSpan? timeout = null)
	{
		ArgumentNullException.ThrowIfNull(r, "r");
		TaskCompletionSource<Response> taskCompletionSource = new TaskCompletionSource<Response>(TaskCreationOptions.RunContinuationsAsynchronously);
		timeout.GetValueOrDefault();
		if (!timeout.HasValue)
		{
			TimeSpan value = TimeSpan.FromSeconds(1L);
			timeout = value;
		}
		r.RequestId = (ulong)Random.Shared.NextInt64();
		ResponseReceived += ResponseReceivedHandler;
		ConnectionStatusChanged += ConnectionStatusReceivedHandler;
		await Send(r, cts).ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			CancellationToken cancellationToken = cts?.Token ?? CancellationToken.None;
			return await taskCompletionSource.Task.WaitAsync(timeout.Value, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (TimeoutException)
		{
			_logger.LogWarning("IPC2 - Timeout waiting for response after {Timeout}ms", timeout.Value.TotalMilliseconds);
			return null;
		}
		catch (OperationCanceledException exception)
		{
			_logger.LogWarning(exception, "IPC2 - Operation was cancelled");
			return null;
		}
		catch (Exception exception2)
		{
			_logger.LogError(exception2, "IPC2 - Unexpected exception");
			return null;
		}
		finally
		{
			ResponseReceived -= ResponseReceivedHandler;
			ConnectionStatusChanged -= ConnectionStatusReceivedHandler;
		}
		void ConnectionStatusReceivedHandler(object? sender, ConnectionStatus status)
		{
			if ((status == ConnectionStatus.Disconnected || status == ConnectionStatus.Error) ? true : false)
			{
				taskCompletionSource.TrySetCanceled();
			}
		}
		void ResponseReceivedHandler(object? sender, ResponseEvent e)
		{
			if (e.Response == null || e.Response.RequestId != r.RequestId)
			{
				return;
			}
			try
			{
				taskCompletionSource.TrySetResult(e.Response);
			}
			catch (Exception exception3)
			{
				_logger.LogError(exception3, "IPC2 - Error calling SetResult on Message");
			}
		}
	}

	public async Task Send(Request request, CancellationTokenSource? cts = null)
	{
		ArgumentNullException.ThrowIfNull(request, "request");
		await _sendLock.WaitAsync().ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			int maxSize = Request.Serializer.GetMaxSize(request);
			if (maxSize <= 0 || maxSize > 67108864)
			{
				throw new InvalidDataException($"IPC2 request must be between 1 and {67108864} bytes");
			}
			int num = maxSize + 4;
			if (num > 0 && _sendbuf.Length < num)
			{
				_sendbuf = new byte[num];
			}
			int num2 = Request.Serializer.Write(_sendbuf.AsSpan(4), request);
			if (num2 <= 0)
			{
				throw new Exception("IPC2 - Error while serializing request");
			}
			uint value = (uint)num2;
			MemoryMarshal.Write(_sendbuf.AsSpan(0, 4), in value);
			Stream stream = _stream;
			if (stream == null)
			{
				ConnectionStatus = ConnectionStatus.Error;
				return;
			}
			CancellationToken cancellationToken = cts?.Token ?? CancellationToken.None;
			if (num2 > 67108864)
			{
				throw new InvalidDataException($"IPC2 request exceeds the {67108864}-byte frame limit");
			}
			await stream.WriteAsync(_sendbuf.AsMemory(0, 4 + num2), cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "IPC2 - Error while writing to the {Transport} stream", SelectedTransport);
			ConnectionStatus = ConnectionStatus.Error;
			RequestDisconnect();
		}
		finally
		{
			_sendLock.Release();
		}
	}

	public async Task Send(ReadOnlyMemory<byte> data, CancellationTokenSource? cts = null)
	{
		Stream stream = _stream;
		if (stream == null)
		{
			ConnectionStatus = ConnectionStatus.Error;
			return;
		}
		await _sendLock.WaitAsync().ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			CancellationToken token = cts?.Token ?? CancellationToken.None;
			if (data.IsEmpty || data.Length > 67108864)
			{
				throw new InvalidDataException($"IPC2 payload must be between 1 and {67108864} bytes");
			}
			uint value = (uint)data.Length;
			MemoryMarshal.Write(_lengthBuffer.AsSpan(), in value);
			await stream.WriteAsync(_lengthBuffer, token).ConfigureAwait(continueOnCapturedContext: false);
			await stream.WriteAsync(data, token).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "IPC2 - Error while writing to the {Transport} stream", SelectedTransport);
			ConnectionStatus = ConnectionStatus.Error;
			RequestDisconnect();
		}
		finally
		{
			_sendLock.Release();
		}
	}

	private async Task ReceiveData()
	{
		Stream stream = _stream;
		if (stream == null)
		{
			ConnectionStatus = ConnectionStatus.Error;
			return;
		}
		byte[] recvLengthBuffer = new byte[4];
		CancellationToken cancellationToken = _cts?.Token ?? CancellationToken.None;
		try
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				await stream.ReadExactlyAsync(recvLengthBuffer, 0, 4, cancellationToken);
				uint messageLength = BitConverter.ToUInt32(recvLengthBuffer, 0);
				if (messageLength == 0 || messageLength > 67108864)
				{
					FarsightIngestDiagnostics.StreamDesynced?.Invoke();
					_logger.LogError("IPC2 - Invalid message length {MessageLength}; maximum is {MaxMessageSize} and zero is not allowed", messageLength, 67108864);
					ConnectionStatus = ConnectionStatus.Error;
					RequestDisconnect();
					break;
				}
				if (messageLength > _recbuf.Length)
				{
					_recbuf = new byte[Math.Min((long)messageLength * 2L, 67108864L)];
				}
				await stream.ReadExactlyAsync(_recbuf, 0, (int)messageLength, cancellationToken);
				HandleFullMessage(messageLength);
			}
		}
		catch (OperationCanceledException)
		{
		}
		catch (EndOfStreamException)
		{
			_logger.LogDebug("IPC2 - {Transport} server closed the stream", SelectedTransport);
			RequestDisconnect();
		}
		catch (Exception exception)
		{
			_logger.LogError(exception, "IPC2 - Error while reading from the {Transport} stream", SelectedTransport);
			ConnectionStatus = ConnectionStatus.Error;
			RequestDisconnect();
		}
	}

	private void HandleFullMessage(uint length, uint offset = 0u)
	{
		FarsightIngestDiagnostics.MessageReceived?.Invoke((int)length);
		long num = ((FarsightIngestDiagnostics.MessageDecoded == null) ? 0 : Stopwatch.GetTimestamp());
		Response response = ISerializerExtensions.Parse(Response.Serializer, new ReadOnlyMemory<byte>(_recbuf, (int)offset, (int)length));
		if (num != 0L)
		{
			FarsightIngestDiagnostics.MessageDecoded?.Invoke(Stopwatch.GetElapsedTime(num).TotalMilliseconds);
		}
		if (response == null)
		{
			_logger.LogError("IPC2 - Received message is null");
		}
		else
		{
			ResponseReceived?.Invoke(this, new ResponseEvent(response));
		}
	}

	public async Task Disconnect()
	{
		if (ConnectionStatus == ConnectionStatus.Disconnected)
		{
			return;
		}
		if (_cts != null)
		{
			try
			{
				_cts.Cancel();
				_cts.Dispose();
				_cts = null;
			}
			catch (ObjectDisposedException)
			{
				_cts = null;
			}
		}
		_stream?.Dispose();
		_stream = null;
		_tcpClient?.Dispose();
		_tcpClient = null;
		SelectedTransport = FarsightIpcTransport.None;
		Task recTask = _recTask;
		_recTask = null;
		if (recTask != null)
		{
			try
			{
				await recTask.ConfigureAwait(continueOnCapturedContext: false);
			}
			catch
			{
			}
			recTask.Dispose();
		}
		ConnectionStatus = ConnectionStatus.Disconnected;
		_logger.LogDebug("IPC2 - Lib transport disconnected");
	}

	private void RequestDisconnect()
	{
		Task.Run((Func<Task?>)Disconnect);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Disconnect().Wait();
		_sendLock.Dispose();
	}
}
