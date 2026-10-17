using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetLayer")]
public class StrokeSetLayer : IFlatBufferSerializable<StrokeSetLayer>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual StrokeLayer Layer { get; set; }

	public static ISerializer<StrokeSetLayer> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetLayer>)this).Serializer;

	ISerializer<StrokeSetLayer> IFlatBufferSerializable<StrokeSetLayer>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetLayer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002ELazySerializer;

	static ISerializer<StrokeSetLayer> IFlatBufferSerializable<StrokeSetLayer>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetLayer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedySerializer;

	static ISerializer<StrokeSetLayer> IFlatBufferSerializable<StrokeSetLayer>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetLayer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetLayer> IFlatBufferSerializable<StrokeSetLayer>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetLayer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetLayer> IFlatBufferSerializable<StrokeSetLayer>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EProgressiveSerializer;

	static StrokeSetLayer()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetLayer_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetLayer()
	{
		Layer = StrokeLayer.underEverything;
	}

	protected StrokeSetLayer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetLayer(StrokeSetLayer source)
	{
		Layer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Layer);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
