using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using Farsight.Utils;

namespace Farsight.IPC2;

internal static class TcpTransport
{
	private const int OWNER_RETRY_COUNT = 10;

	private const int OWNER_RETRY_DELAY_MS = 25;

	internal static bool IsServerPortBound(FarsightServerIdentity server, ushort port)
	{
		return TcpInfo.IsProcessBoundToPort((uint)server.ProcessId, port);
	}

	internal static async Task<TcpClient> ConnectAsync(FarsightServerIdentity server, string host, int port, int receiveBufferSize, int sendBufferSize, CancellationToken cancellationToken)
	{
		TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork)
		{
			ReceiveBufferSize = receiveBufferSize,
			SendBufferSize = sendBufferSize
		};
		try
		{
			await tcpClient.ConnectAsync(host, port, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await VerifyServerOwner(tcpClient, server, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return tcpClient;
		}
		catch
		{
			tcpClient.Dispose();
			throw;
		}
	}

	private static async Task VerifyServerOwner(TcpClient tcpClient, FarsightServerIdentity server, CancellationToken cancellationToken)
	{
		EndPoint localEndPoint = tcpClient.Client.LocalEndPoint;
		if (localEndPoint is IPEndPoint clientEndpoint)
		{
			localEndPoint = tcpClient.Client.RemoteEndPoint;
			if (localEndPoint is IPEndPoint serverEndpoint)
			{
				for (int attempt = 0; attempt < 10; attempt++)
				{
					server.EnsureLive();
					if (TcpInfo.IsConnectionOwnedBy((uint)server.ProcessId, serverEndpoint, clientEndpoint))
					{
						return;
					}
					await Task.Delay(25, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				throw new SecurityException($"Legacy TCP listener is not owned by League PID {server.ProcessId}");
			}
		}
		throw new SecurityException("Could not resolve legacy TCP connection endpoints");
	}
}
