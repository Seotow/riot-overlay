using System;

namespace Farsight;

public class PenEraserStateChangedEventArgs : EventArgs
{
	public bool Hovering { get; set; }

	public bool InContact { get; set; }
}
