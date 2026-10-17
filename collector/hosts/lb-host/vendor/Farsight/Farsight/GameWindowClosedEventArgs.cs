using System;

namespace Farsight;

public class GameWindowClosedEventArgs(nint windowHandle) : EventArgs
{
	public nint WindowHandle { get; init; } = windowHandle;
}
