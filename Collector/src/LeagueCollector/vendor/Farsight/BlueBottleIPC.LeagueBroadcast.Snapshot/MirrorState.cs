using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.MirrorState")]
public class MirrorState : IFlatBufferSerializable<MirrorState>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(1)]
	public virtual float PlaybackSpeed { get; set; }

	[FlatBufferItem(2)]
	public virtual byte GameState { get; set; }

	[FlatBufferItem(3)]
	public virtual ulong UtcTime { get; set; }

	public static ISerializer<MirrorState> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<MirrorState>)this).Serializer;

	ISerializer<MirrorState> IFlatBufferSerializable<MirrorState>.Serializer => Serializer;

	private static readonly ISerializer<MirrorState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002ELazySerializer;

	static ISerializer<MirrorState> IFlatBufferSerializable<MirrorState>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002ELazySerializer;

	private static readonly ISerializer<MirrorState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedySerializer;

	static ISerializer<MirrorState> IFlatBufferSerializable<MirrorState>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedySerializer;

	private static readonly ISerializer<MirrorState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedyMutableSerializer;

	static ISerializer<MirrorState> IFlatBufferSerializable<MirrorState>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<MirrorState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EProgressiveSerializer;

	static ISerializer<MirrorState> IFlatBufferSerializable<MirrorState>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EProgressiveSerializer;

	static MirrorState()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EMirrorState_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public MirrorState()
	{
		GameTime = 0f;
		PlaybackSpeed = 0f;
		GameState = 0;
		UtcTime = 0uL;
	}

	protected MirrorState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public MirrorState(MirrorState source)
	{
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		PlaybackSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlaybackSpeed);
		GameState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameState);
		UtcTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.UtcTime);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
