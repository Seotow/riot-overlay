using System;
using System.Collections.Generic;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Snapshot;

namespace Farsight;

public class StrokeSyncEventArgs : EventArgs
{
	public required StrokeSyncEventType EventType { get; init; }

	public required string StrokeId { get; init; }

	public ColorRGBA? Color { get; init; }

	public float? Width { get; init; }

	public StrokeLayer? Layer { get; init; }

	public StrokeTipStyle? StartTip { get; init; }

	public StrokeTipStyle? EndTip { get; init; }

	public StrokeLineStyle? LineStyle { get; init; }

	public float? VanishTime { get; init; }

	public StrokeTimeMode? TimeMode { get; init; }

	public IReadOnlyList<float>? PointGameTimes { get; init; }

	public bool IsArea { get; init; }

	public bool HasOutline { get; init; }

	public ColorRGBA? FillColor { get; init; }

	public uint AnchorNetworkId { get; init; }

	public IReadOnlyList<Vector3>? Points { get; init; }

	public IReadOnlyList<float>? Pressures { get; init; }
}
