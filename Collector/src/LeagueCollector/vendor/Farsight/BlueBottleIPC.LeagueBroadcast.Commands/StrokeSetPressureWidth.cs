using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetPressureWidth")]
public class StrokeSetPressureWidth : IFlatBufferSerializable<StrokeSetPressureWidth>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual float MinScale { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<float>? CurveX { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<float>? CurveY { get; set; }

	public static ISerializer<StrokeSetPressureWidth> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetPressureWidth>)this).Serializer;

	ISerializer<StrokeSetPressureWidth> IFlatBufferSerializable<StrokeSetPressureWidth>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetPressureWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002ELazySerializer;

	static ISerializer<StrokeSetPressureWidth> IFlatBufferSerializable<StrokeSetPressureWidth>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetPressureWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedySerializer;

	static ISerializer<StrokeSetPressureWidth> IFlatBufferSerializable<StrokeSetPressureWidth>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetPressureWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetPressureWidth> IFlatBufferSerializable<StrokeSetPressureWidth>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetPressureWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetPressureWidth> IFlatBufferSerializable<StrokeSetPressureWidth>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EProgressiveSerializer;

	static StrokeSetPressureWidth()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetPressureWidth_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetPressureWidth()
	{
		Enabled = false;
		MinScale = 0f;
		CurveX = null;
		CurveY = null;
	}

	protected StrokeSetPressureWidth(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetPressureWidth(StrokeSetPressureWidth source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		MinScale = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinScale);
		CurveX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CurveX);
		CurveY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CurveY);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
