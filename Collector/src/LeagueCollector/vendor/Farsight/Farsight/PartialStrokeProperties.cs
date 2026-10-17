using BlueBottleIPC.LeagueBroadcast.Common;

namespace Farsight;

public class PartialStrokeProperties
{
	public bool? Active { get; set; }

	public StrokeTool? Tool { get; set; }

	public ColorRGBA? Color { get; set; }

	public float? Width { get; set; }

	public StrokeLayer? Layer { get; set; }

	public StrokeTipStyle? StartTip { get; set; }

	public StrokeTipStyle? EndTip { get; set; }

	public StrokeLineStyle? LineStyle { get; set; }

	public float? VanishTime { get; set; }

	public StrokeTimeMode? TimeMode { get; set; }

	public ColorRGBA? FillColor { get; set; }

	public bool? HasOutline { get; set; }

	public bool? AnchorMode { get; set; }

	public uint? SelectedAnchorNetworkId { get; set; }

	public uint? CameraLockNetworkId { get; set; }
}
