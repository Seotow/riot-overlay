using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetColor")]
public class StrokeSetColor : IFlatBufferSerializable<StrokeSetColor>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ColorRGBA Color { get; set; }

	public static ISerializer<StrokeSetColor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetColor>)this).Serializer;

	ISerializer<StrokeSetColor> IFlatBufferSerializable<StrokeSetColor>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002ELazySerializer;

	static ISerializer<StrokeSetColor> IFlatBufferSerializable<StrokeSetColor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedySerializer;

	static ISerializer<StrokeSetColor> IFlatBufferSerializable<StrokeSetColor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetColor> IFlatBufferSerializable<StrokeSetColor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetColor> IFlatBufferSerializable<StrokeSetColor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EProgressiveSerializer;

	static StrokeSetColor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetColor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetColor()
	{
	}

	protected StrokeSetColor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetColor(StrokeSetColor source)
	{
		Color = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Color);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
