using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Farsight.IPC2;

internal static class NamedPipeTransport
{
	private enum PipeAdmission
	{
		Ready,
		RejectedBeforeAdmission
	}

	private const int CONNECT_BUDGET_MS = 2000;

	private const int CONNECT_SLICE_MS = 250;

	private const int RETRY_DELAY_MS = 25;

	private const int READY_TIMEOUT_MS = 5000;

	private const int ERROR_SUCCESS = 0;

	private const int ERROR_FILE_NOT_FOUND = 2;

	private const int ERROR_PATH_NOT_FOUND = 3;

	private const int ERROR_ACCESS_DENIED = 5;

	private const int ERROR_NOT_SUPPORTED = 50;

	private const int ERROR_BROKEN_PIPE = 109;

	private const int ERROR_CALL_NOT_IMPLEMENTED = 120;

	private const int ERROR_SEM_TIMEOUT = 121;

	private const int ERROR_PIPE_BUSY = 231;

	private const int ERROR_NO_DATA = 232;

	private const int ERROR_PIPE_NOT_CONNECTED = 233;

	private const uint NMPWAIT_NOWAIT = 1u;

	private static readonly byte[] READY_MARKER = new byte[4] { 66, 66, 80, 50 };

	[LibraryImport("kernel32.dll", SetLastError = true)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static bool GetNamedPipeServerProcessId(SafePipeHandle pipe, out uint serverProcessId)
	{
		serverProcessId = 0u;
		bool result = false;
		int num = 0;
		SafeHandleMarshaller<SafePipeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default;
		int lastSystemError;
		try
		{
			managedToUnmanagedIn.FromManaged(pipe);
			fixed (uint* _serverProcessId_native = &serverProcessId)
			{
				nint _pipe_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				num = __PInvoke(_pipe_native, _serverProcessId_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			result = num != 0;
		}
		finally
		{
			managedToUnmanagedIn.Free();
		}
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("kernel32.dll", EntryPoint = "GetNamedPipeServerProcessId", ExactSpelling = true)]
		unsafe static extern int __PInvoke(nint __pipe_native, uint* __serverProcessId_native);
	}

	[LibraryImport("kernel32.dll", EntryPoint = "WaitNamedPipeW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "10.0.14.37416")]
	[SkipLocalsInit]
	[return: MarshalAs(UnmanagedType.Bool)]
	private unsafe static bool WaitNamedPipe(string name, uint timeout)
	{
		int num;
		int lastSystemError;
		fixed (char* ptr = &Utf16StringMarshaller.GetPinnableReference(name))
		{
			void* _name_native = ptr;
			Marshal.SetLastSystemError(0);
			num = __PInvoke((ushort*)_name_native, timeout);
			lastSystemError = Marshal.GetLastSystemError();
		}
		bool result = num != 0;
		Marshal.SetLastPInvokeError(lastSystemError);
		return result;
		[DllImport("kernel32.dll", EntryPoint = "WaitNamedPipeW", ExactSpelling = true)]
		unsafe static extern int __PInvoke(ushort* __name_native, uint __timeout_native);
	}

	internal static bool ProbeExists(FarsightServerIdentity server)
	{
		if (WaitNamedPipe(FarsightPipeName.GetFullPath(server.SessionId, server.ProcessId), 1u))
		{
			return true;
		}
		int lastPInvokeError = Marshal.GetLastPInvokeError();
		if (lastPInvokeError == 5 || lastPInvokeError == 121 || lastPInvokeError == 231)
		{
			return true;
		}
		return false;
	}

	internal static async Task<(NamedPipeClientStream? Pipe, NamedPipeConnectFailure? Failure)> TryConnectAsync(FarsightServerIdentity server, CancellationToken cancellationToken)
	{
		var (pipe, item) = await ConnectVerifiedAsync(server, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (pipe == null)
		{
			return (Pipe: null, Failure: item);
		}
		PipeAdmission pipeAdmission;
		try
		{
			pipeAdmission = await WaitForAdmissionAsync(pipe, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch
		{
			pipe.Dispose();
			throw;
		}
		if (pipeAdmission == PipeAdmission.Ready)
		{
			return (Pipe: pipe, Failure: null);
		}
		pipe.Dispose();
		return (Pipe: null, Failure: NamedPipeConnectFailure.Rejected);
	}

	private static async Task<(NamedPipeClientStream? Pipe, NamedPipeConnectFailure? Failure)> ConnectVerifiedAsync(FarsightServerIdentity server, CancellationToken cancellationToken)
	{
		string pipeName = FarsightPipeName.ForProcess(server.SessionId, server.ProcessId);
		string pipePath = FarsightPipeName.GetFullPath(server.SessionId, server.ProcessId);
		long deadline = Stopwatch.GetTimestamp() + (long)((double)Stopwatch.Frequency * 2.0);
		int lastError = 2;
		while (Stopwatch.GetTimestamp() < deadline)
		{
			cancellationToken.ThrowIfCancellationRequested();
			server.EnsureLive();
			NamedPipeClientStream pipe = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.Anonymous);
			bool accepted = false;
			try
			{
				int timeout = Math.Clamp((int)Stopwatch.GetElapsedTime(Stopwatch.GetTimestamp(), deadline).TotalMilliseconds, 1, 250);
				await pipe.ConnectAsync(timeout, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				VerifyServerProcess(pipe, server);
				accepted = true;
				return (Pipe: pipe, Failure: null);
			}
			catch (TimeoutException)
			{
				lastError = GetPipeAvailabilityError(pipePath);
			}
			catch (Win32Exception ex2) when (IsPipeClosedError(ex2.NativeErrorCode))
			{
				return (Pipe: null, Failure: NamedPipeConnectFailure.Rejected);
			}
			catch (IOException exception) when (IsRetryablePipeError(GetWin32Error(exception)) || IsUnsupportedPipeError(GetWin32Error(exception)))
			{
				lastError = GetWin32Error(exception);
			}
			catch (PlatformNotSupportedException)
			{
				return (Pipe: null, Failure: NamedPipeConnectFailure.Unsupported);
			}
			finally
			{
				if (!accepted)
				{
					pipe.Dispose();
				}
			}
			if (IsUnsupportedPipeError(lastError))
			{
				return (Pipe: null, Failure: NamedPipeConnectFailure.Unsupported);
			}
			if (!IsRetryablePipeError(lastError) && lastError != 0)
			{
				throw new IOException($"Named pipe discovery failed with Win32 error {lastError}", new Win32Exception(lastError));
			}
			await Task.Delay(25, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if ((uint)(lastError - 2) <= 1u)
		{
			return (Pipe: null, Failure: NamedPipeConnectFailure.Absent);
		}
		throw new IOException($"Named pipe {pipePath} exists but remained unavailable (Win32 error {lastError})", new Win32Exception(lastError));
	}

	private static void VerifyServerProcess(NamedPipeClientStream pipe, FarsightServerIdentity server)
	{
		if (!GetNamedPipeServerProcessId(pipe.SafePipeHandle, out var serverProcessId))
		{
			throw new Win32Exception(Marshal.GetLastPInvokeError(), "Could not identify the named pipe server process");
		}
		if (serverProcessId != (uint)server.ProcessId)
		{
			throw new SecurityException($"Named pipe server PID {serverProcessId} does not match League PID {server.ProcessId}");
		}
		server.EnsureLive();
	}

	private static async Task<PipeAdmission> WaitForAdmissionAsync(NamedPipeClientStream pipe, CancellationToken cancellationToken)
	{
		byte[] marker = new byte[READY_MARKER.Length];
		int bytesRead = 0;
		using CancellationTokenSource readyCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		readyCts.CancelAfter(5000);
		try
		{
			int num;
			for (; bytesRead < marker.Length; bytesRead += num)
			{
				try
				{
					num = await pipe.ReadAsync(marker.AsMemory(bytesRead), readyCts.Token).ConfigureAwait(continueOnCapturedContext: false);
				}
				catch (IOException exception) when (bytesRead == 0 && IsPipeClosedError(GetWin32Error(exception)))
				{
					return PipeAdmission.RejectedBeforeAdmission;
				}
				if (num == 0)
				{
					if (bytesRead == 0)
					{
						return PipeAdmission.RejectedBeforeAdmission;
					}
					throw new EndOfStreamException("Named pipe closed during its admission marker");
				}
			}
		}
		catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
		{
			throw new TimeoutException("Timed out waiting for named-pipe admission");
		}
		if (((ReadOnlySpan<byte>)marker.AsSpan()).SequenceEqual((ReadOnlySpan<byte>)READY_MARKER))
		{
			return PipeAdmission.Ready;
		}
		throw new InvalidDataException("Named pipe returned an invalid admission marker");
	}

	private static int GetPipeAvailabilityError(string pipePath)
	{
		if (!WaitNamedPipe(pipePath, 1u))
		{
			return Marshal.GetLastPInvokeError();
		}
		return 0;
	}

	private static int GetWin32Error(IOException exception)
	{
		return exception.HResult & 0xFFFF;
	}

	private static bool IsRetryablePipeError(int error)
	{
		if ((uint)(error - 2) <= 1u || error == 121 || error == 231)
		{
			return true;
		}
		return false;
	}

	private static bool IsUnsupportedPipeError(int error)
	{
		if (error == 50 || error == 120)
		{
			return true;
		}
		return false;
	}

	private static bool IsPipeClosedError(int error)
	{
		if (error == 109 || (uint)(error - 232) <= 1u)
		{
			return true;
		}
		return false;
	}
}
