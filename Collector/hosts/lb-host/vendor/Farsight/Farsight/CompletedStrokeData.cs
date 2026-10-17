using System;
using System.Collections.Generic;
using System.Drawing;
using BlueBottleIPC.LeagueBroadcast.Common;

namespace Farsight;

public class CompletedStrokeData
{
	public required string StrokeId { get; init; }

	public required Color Color { get; init; }

	public required float Width { get; init; }

	public required StrokeLayer Layer { get; init; }

	public required StrokeTipStyle StartTip { get; init; }

	public required StrokeTipStyle EndTip { get; init; }

	public required StrokeLineStyle LineStyle { get; init; }

	public float VanishTime { get; init; }

	public StrokeTimeMode TimeMode { get; init; }

	public IReadOnlyList<float> PointGameTimes { get; init; } = Array.Empty<float>();

	public bool IsArea { get; init; }

	public bool HasOutline { get; init; }

	public Color? FillColor { get; init; }

	public uint AnchorNetworkId { get; init; }

	public required IReadOnlyList<Vector3> Points { get; init; }

	public IReadOnlyList<float>? Pressures { get; init; }
}
