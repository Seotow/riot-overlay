using System;

namespace Farsight;

public class StrokeActionEventArgs(StrokeActionType actionType) : EventArgs
{
	public StrokeActionType ActionType { get; } = actionType;
}
