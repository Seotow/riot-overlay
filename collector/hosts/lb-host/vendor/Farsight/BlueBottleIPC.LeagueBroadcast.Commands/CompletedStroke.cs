using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CompletedStroke")]
public class CompletedStroke
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string StrokeId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ColorRGBA Color { get; set; }

	[FlatBufferItem(2)]
	public virtual float Width { get; set; }

	[FlatBufferItem(3)]
	public virtual StrokeLayer Layer { get; set; }

	[FlatBufferItem(4)]
	public virtual StrokeTipStyle StartTip { get; set; }

	[FlatBufferItem(5)]
	public virtual StrokeTipStyle EndTip { get; set; }

	[FlatBufferItem(6)]
	public virtual StrokeLineStyle LineStyle { get; set; }

	[FlatBufferItem(7)]
	public virtual float VanishTime { get; set; }

	[FlatBufferItem(8)]
	public virtual StrokeTimeMode TimeMode { get; set; }

	[FlatBufferItem(9, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required IList<Vector3> Points { get; set; }

	[FlatBufferItem(10)]
	public virtual IList<float>? PointGameTimes { get; set; }

	[FlatBufferItem(11)]
	public virtual bool IsArea { get; set; }

	[FlatBufferItem(12)]
	public virtual bool HasOutline { get; set; }

	[FlatBufferItem(13)]
	public virtual ColorRGBA? FillColor { get; set; }

	[FlatBufferItem(14)]
	public virtual uint AnchorNetworkId { get; set; }

	[FlatBufferItem(15)]
	public virtual IList<float>? Pressures { get; set; }

	static CompletedStroke()
	{
	}

	public CompletedStroke()
	{
		Width = 0f;
		Layer = StrokeLayer.underEverything;
		StartTip = StrokeTipStyle.circle;
		EndTip = StrokeTipStyle.circle;
		LineStyle = StrokeLineStyle.solid;
		VanishTime = 0f;
		TimeMode = StrokeTimeMode.wallClock;
		PointGameTimes = null;
		IsArea = false;
		HasOutline = false;
		FillColor = null;
		AnchorNetworkId = 0u;
		Pressures = null;
	}

	protected CompletedStroke(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CompletedStroke(CompletedStroke source)
	{
		StrokeId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StrokeId);
		Color = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Color);
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
		Layer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Layer);
		StartTip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StartTip);
		EndTip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EndTip);
		LineStyle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LineStyle);
		VanishTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VanishTime);
		TimeMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TimeMode);
		Points = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Points);
		PointGameTimes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PointGameTimes);
		IsArea = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsArea);
		HasOutline = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HasOutline);
		FillColor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FillColor);
		AnchorNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorNetworkId);
		Pressures = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Pressures);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
