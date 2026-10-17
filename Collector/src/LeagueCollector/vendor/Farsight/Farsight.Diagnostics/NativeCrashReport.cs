using System;

namespace Farsight.Diagnostics;

public sealed class NativeCrashReport
{
	private readonly byte[] _minidump;

	public int ProcessId { get; }

	public uint ThreadId { get; }

	public uint ExceptionCode { get; }

	public DateTimeOffset TimestampUtc { get; }

	public ulong ExceptionAddress { get; }

	public ulong ModuleOffset { get; }

	public string ModulePath { get; }

	public uint DumpError { get; }

	public ReadOnlyMemory<byte> Minidump => _minidump;

	public string Summary => $"Native League crash at {TimestampUtc:O}\nProcess: {ProcessId}; thread: {ThreadId}\nException: 0x{ExceptionCode:X8} at 0x{ExceptionAddress:X}\nModule: {ModulePath} + 0x{ModuleOffset:X}\nMinidump: {_minidump.Length} bytes; error: {DumpError}";

	internal NativeCrashReport(int processId, uint threadId, uint exceptionCode, DateTimeOffset timestampUtc, ulong exceptionAddress, ulong moduleOffset, string modulePath, uint dumpError, byte[] minidump)
	{
		ProcessId = processId;
		ThreadId = threadId;
		ExceptionCode = exceptionCode;
		TimestampUtc = timestampUtc;
		ExceptionAddress = exceptionAddress;
		ModuleOffset = moduleOffset;
		ModulePath = modulePath;
		DumpError = dumpError;
		_minidump = minidump;
	}
}
