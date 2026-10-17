using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.StrokeProperties")]
public class StrokeProperties
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual StrokeLayer Layer { get; set; }

	[FlatBufferItem(2)]
	public virtual StrokeTipStyle StartStyle { get; set; }

	[FlatBufferItem(3)]
	public virtual StrokeTipStyle EndStyle { get; set; }

	[FlatBufferItem(4)]
	public virtual ColorRGBA? Color { get; set; }

	[FlatBufferItem(5)]
	public virtual StrokeLineStyle LineStyle { get; set; }

	[FlatBufferItem(6)]
	public virtual float Width { get; set; }

	[FlatBufferItem(7)]
	public virtual float VanishTime { get; set; }

	[FlatBufferItem(8)]
	public virtual StrokeTimeMode TimeMode { get; set; }

	[FlatBufferItem(9)]
	public virtual bool AnchorMode { get; set; }

	[FlatBufferItem(10)]
	public virtual uint SelectedAnchorNetworkId { get; set; }

	[FlatBufferItem(11)]
	public virtual IList<uint>? AnchorTargets { get; set; }

	[FlatBufferItem(12)]
	public virtual uint CameraLockNetworkId { get; set; }

	static StrokeProperties()
	{
	}

	public StrokeProperties()
	{
		Enabled = false;
		Layer = StrokeLayer.underEverything;
		StartStyle = StrokeTipStyle.circle;
		EndStyle = StrokeTipStyle.circle;
		Color = null;
		LineStyle = StrokeLineStyle.solid;
		Width = 0f;
		VanishTime = 0f;
		TimeMode = StrokeTimeMode.wallClock;
		AnchorMode = false;
		SelectedAnchorNetworkId = 0u;
		AnchorTargets = null;
		CameraLockNetworkId = 0u;
	}

	protected StrokeProperties(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeProperties(StrokeProperties source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		Layer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Layer);
		StartStyle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StartStyle);
		EndStyle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EndStyle);
		Color = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Color);
		LineStyle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LineStyle);
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
		VanishTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VanishTime);
		TimeMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TimeMode);
		AnchorMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorMode);
		SelectedAnchorNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SelectedAnchorNetworkId);
		AnchorTargets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorTargets);
		CameraLockNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraLockNetworkId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
