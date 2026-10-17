using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete")]
public class StrokeDrawComplete : IFlatBufferSerializable<StrokeDrawComplete>, IFlatBufferSerializable
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
	public virtual float RevealDuration { get; set; }

	[FlatBufferItem(15)]
	public virtual uint AnchorNetworkId { get; set; }

	public static ISerializer<StrokeDrawComplete> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeDrawComplete>)this).Serializer;

	ISerializer<StrokeDrawComplete> IFlatBufferSerializable<StrokeDrawComplete>.Serializer => Serializer;

	private static readonly ISerializer<StrokeDrawComplete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002ELazySerializer;

	static ISerializer<StrokeDrawComplete> IFlatBufferSerializable<StrokeDrawComplete>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeDrawComplete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedySerializer;

	static ISerializer<StrokeDrawComplete> IFlatBufferSerializable<StrokeDrawComplete>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeDrawComplete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeDrawComplete> IFlatBufferSerializable<StrokeDrawComplete>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeDrawComplete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EProgressiveSerializer;

	static ISerializer<StrokeDrawComplete> IFlatBufferSerializable<StrokeDrawComplete>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EProgressiveSerializer;

	static StrokeDrawComplete()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeDrawComplete_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeDrawComplete()
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
		RevealDuration = 0f;
		AnchorNetworkId = 0u;
	}

	protected StrokeDrawComplete(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeDrawComplete(StrokeDrawComplete source)
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
		RevealDuration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RevealDuration);
		AnchorNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorNetworkId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
