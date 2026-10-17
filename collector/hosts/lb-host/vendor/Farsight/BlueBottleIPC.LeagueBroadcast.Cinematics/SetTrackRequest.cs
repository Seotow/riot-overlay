using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N857BB370BE5327693C287E9DD618A992CBB883344550AE6BEE3B33DFD479C0D5;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.SetTrackRequest")]
public class SetTrackRequest : IFlatBufferSerializable<SetTrackRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? PropId { get; set; }

	[FlatBufferItem(2)]
	public virtual CinematicTrack? Track { get; set; }

	public static ISerializer<SetTrackRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetTrackRequest>)this).Serializer;

	ISerializer<SetTrackRequest> IFlatBufferSerializable<SetTrackRequest>.Serializer => Serializer;

	private static readonly ISerializer<SetTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002ELazySerializer;

	static ISerializer<SetTrackRequest> IFlatBufferSerializable<SetTrackRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002ELazySerializer;

	private static readonly ISerializer<SetTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedySerializer;

	static ISerializer<SetTrackRequest> IFlatBufferSerializable<SetTrackRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<SetTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<SetTrackRequest> IFlatBufferSerializable<SetTrackRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EProgressiveSerializer;

	static ISerializer<SetTrackRequest> IFlatBufferSerializable<SetTrackRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EProgressiveSerializer;

	static SetTrackRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetTrackRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetTrackRequest()
	{
		CinematicId = null;
		PropId = null;
		Track = null;
	}

	protected SetTrackRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetTrackRequest(SetTrackRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		PropId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PropId);
		Track = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Track);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
