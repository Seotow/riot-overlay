using System;
using System.Buffers.Binary;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Farsight.Diagnostics;

internal sealed class NativeCrashMonitor : IDisposable
{
	internal const int HeaderSize = 576;

	internal const int MaxDumpSize = 67108864;

	private const string ChannelPrefix = "Local\\BlueBottleGG.Farsight.Crash.v1.";

	private readonly CancellationTokenSource _stop = new CancellationTokenSource();

	private readonly MemoryMappedFile _mapping;

	private readonly EventWaitHandle _ready;

	private readonly Process? _process;

	private readonly int _expectedPid;

	private readonly Action<NativeCrashReport> _received;

	internal NativeCrashMonitor(string name, int expectedPid, Action<NativeCrashReport> received)
	{
		if (!name.StartsWith("Local\\BlueBottleGG.Farsight.Crash.v1.", StringComparison.Ordinal) || !Guid.TryParseExact(name.AsSpan("Local\\BlueBottleGG.Farsight.Crash.v1.".Length), "B", out var _) || expectedPid <= 0)
		{
			throw new InvalidDataException("Invalid native crash channel identity");
		}
		_expectedPid = expectedPid;
		_received = received;
		_mapping = MemoryMappedFile.OpenExisting(name, MemoryMappedFileRights.Read);
		try
		{
			_ready = EventWaitHandle.OpenExisting(name + ".ready");
			try
			{
				_process = Process.GetProcessById(expectedPid);
			}
			catch (ArgumentException)
			{
			}
			catch
			{
				_ready.Dispose();
				throw;
			}
		}
		catch
		{
			_mapping.Dispose();
			throw;
		}
		Task.Run((Action)Watch);
	}

	private void Watch()
	{
		try
		{
			using MemoryMappedViewAccessor view = _mapping.CreateViewAccessor(0L, 67109440L, MemoryMappedFileAccess.Read);
			WaitHandle[] waitHandles = new WaitHandle[2]
			{
				_ready,
				_stop.Token.WaitHandle
			};
			while (!_stop.IsCancellationRequested)
			{
				if (_ready.WaitOne(0))
				{
					NativeCrashReport nativeCrashReport = ReadReport(view, _expectedPid);
					if (nativeCrashReport != null && !_stop.IsCancellationRequested)
					{
						_received(nativeCrashReport);
					}
					break;
				}
				if (HasProcessExited())
				{
					if (_ready.WaitOne(0))
					{
						NativeCrashReport nativeCrashReport2 = ReadReport(view, _expectedPid);
						if (nativeCrashReport2 != null && !_stop.IsCancellationRequested)
						{
							_received(nativeCrashReport2);
						}
					}
					break;
				}
				if (WaitHandle.WaitAny(waitHandles, 250) == 1)
				{
					break;
				}
			}
		}
		catch (Exception exception)
		{
			LeagueConnector.Logger?.LogWarning(exception, "Native crash channel watch failed");
		}
		finally
		{
			_process?.Dispose();
			_ready.Dispose();
			_mapping.Dispose();
			_stop.Dispose();
		}
	}

	private bool HasProcessExited()
	{
		try
		{
			return _process == null || _process.HasExited;
		}
		catch (Win32Exception)
		{
			return false;
		}
	}

	internal static NativeCrashReport? ReadReport(MemoryMappedViewAccessor view, int expectedPid)
	{
		if (view.ReadInt32(8L) != 2)
		{
			return null;
		}
		byte[] array = new byte[576];
		view.ReadArray(0L, array, 0, array.Length);
		ReadOnlySpan<byte> source = array;
		uint num = BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(48));
		long num2 = BinaryPrimitives.ReadInt64LittleEndian(source.Slice(24));
		if (BinaryPrimitives.ReadUInt32LittleEndian(source) != 1179861842 || BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(4)) != 1 || BinaryPrimitives.ReadInt32LittleEndian(source.Slice(8)) != 2 || BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(12)) != expectedPid || BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(16)) == 0 || num > 67108864 || num2 <= 0 || (num != 0 && BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(52)) != 0) || 576 + num > view.Capacity)
		{
			return null;
		}
		DateTimeOffset timestampUtc;
		try
		{
			timestampUtc = new DateTimeOffset(DateTime.FromFileTimeUtc(num2));
		}
		catch (ArgumentOutOfRangeException)
		{
			return null;
		}
		byte[] array2 = new byte[num];
		if (array2.Length != 0)
		{
			view.ReadArray(576L, array2, 0, array2.Length);
			if (array2.Length < 4 || BinaryPrimitives.ReadUInt32LittleEndian(array2) != 1347241037)
			{
				return null;
			}
		}
		ReadOnlySpan<byte> readOnlySpan = source.Slice(56, 520);
		int i;
		for (i = 0; i < readOnlySpan.Length && BinaryPrimitives.ReadUInt16LittleEndian(readOnlySpan.Slice(i)) != 0; i += 2)
		{
		}
		return new NativeCrashReport(expectedPid, BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(16)), BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(20)), timestampUtc, BinaryPrimitives.ReadUInt64LittleEndian(source.Slice(32)), BinaryPrimitives.ReadUInt64LittleEndian(source.Slice(40)), Encoding.Unicode.GetString(readOnlySpan.Slice(0, i)), BinaryPrimitives.ReadUInt32LittleEndian(source.Slice(52)), array2);
	}

	public void Dispose()
	{
		try
		{
			_stop.Cancel();
		}
		catch (ObjectDisposedException)
		{
		}
	}
}
