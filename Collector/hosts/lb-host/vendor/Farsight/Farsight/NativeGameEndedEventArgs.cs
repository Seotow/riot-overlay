using System;

namespace Farsight;

public class NativeGameEndedEventArgs(NativeGameEndCause cause = NativeGameEndCause.Unknown) : EventArgs
{
	public NativeGameEndCause Cause { get; init; } = cause;
}
