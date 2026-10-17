using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeClear")]
public class StrokeClear : IFlatBufferSerializable<StrokeClear>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual StrokeLayer Layer { get; set; }

	public static ISerializer<StrokeClear> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeClear>)this).Serializer;

	ISerializer<StrokeClear> IFlatBufferSerializable<StrokeClear>.Serializer => Serializer;

	private static readonly ISerializer<StrokeClear> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002ELazySerializer;

	static ISerializer<StrokeClear> IFlatBufferSerializable<StrokeClear>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeClear> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedySerializer;

	static ISerializer<StrokeClear> IFlatBufferSerializable<StrokeClear>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeClear> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeClear> IFlatBufferSerializable<StrokeClear>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeClear> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EProgressiveSerializer;

	static ISerializer<StrokeClear> IFlatBufferSerializable<StrokeClear>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EProgressiveSerializer;

	static StrokeClear()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeClear_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeClear()
	{
		Layer = StrokeLayer.underEverything;
	}

	protected StrokeClear(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeClear(StrokeClear source)
	{
		Layer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Layer);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
