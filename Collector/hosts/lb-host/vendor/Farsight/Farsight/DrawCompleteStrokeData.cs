using System.Collections.Generic;
using System.Drawing;
using BlueBottleIPC.LeagueBroadcast.Common;

namespace Farsight;

public class DrawCompleteStrokeData
{
	public required string StrokeId { get; init; }

	public required IReadOnlyList<Vector3> Points { get; init; }

	public required Color Color { get; init; }

	public float Width { get; init; } = 12f;

	public StrokeLayer Layer { get; init; } = StrokeLayer.aboveTerrain;

	public StrokeTipStyle StartTip { get; init; }

	public StrokeTipStyle EndTip { get; init; }

	public StrokeLineStyle LineStyle { get; init; }

	public float VanishTime { get; init; }

	public StrokeTimeMode TimeMode { get; init; } = StrokeTimeMode.wallClockReveal;

	public float RevealDuration { get; init; }

	public IReadOnlyList<float>? PointGameTimes { get; init; }

	public bool IsArea { get; init; }

	public bool HasOutline { get; init; } = true;

	public Color? FillColor { get; init; }

	public uint AnchorNetworkId { get; init; }
}
