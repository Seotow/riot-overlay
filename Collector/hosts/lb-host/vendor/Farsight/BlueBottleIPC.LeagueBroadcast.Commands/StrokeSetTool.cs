using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetTool")]
public class StrokeSetTool : IFlatBufferSerializable<StrokeSetTool>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual StrokeTool Tool { get; set; }

	public static ISerializer<StrokeSetTool> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetTool>)this).Serializer;

	ISerializer<StrokeSetTool> IFlatBufferSerializable<StrokeSetTool>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetTool> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002ELazySerializer;

	static ISerializer<StrokeSetTool> IFlatBufferSerializable<StrokeSetTool>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetTool> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedySerializer;

	static ISerializer<StrokeSetTool> IFlatBufferSerializable<StrokeSetTool>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetTool> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetTool> IFlatBufferSerializable<StrokeSetTool>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetTool> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetTool> IFlatBufferSerializable<StrokeSetTool>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EProgressiveSerializer;

	static StrokeSetTool()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTool_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetTool()
	{
		Tool = StrokeTool.pen;
	}

	protected StrokeSetTool(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetTool(StrokeSetTool source)
	{
		Tool = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Tool);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
