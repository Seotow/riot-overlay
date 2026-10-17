using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0980EE9C083BB24C9FE0F0B575E6110563EDC052101A173537C08A800A4FCFC0;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.SetHudTrackRequest")]
public class SetHudTrackRequest : IFlatBufferSerializable<SetHudTrackRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual CinematicHudTrack? Track { get; set; }

	public static ISerializer<SetHudTrackRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetHudTrackRequest>)this).Serializer;

	ISerializer<SetHudTrackRequest> IFlatBufferSerializable<SetHudTrackRequest>.Serializer => Serializer;

	private static readonly ISerializer<SetHudTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002ELazySerializer;

	static ISerializer<SetHudTrackRequest> IFlatBufferSerializable<SetHudTrackRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002ELazySerializer;

	private static readonly ISerializer<SetHudTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedySerializer;

	static ISerializer<SetHudTrackRequest> IFlatBufferSerializable<SetHudTrackRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<SetHudTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<SetHudTrackRequest> IFlatBufferSerializable<SetHudTrackRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetHudTrackRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EProgressiveSerializer;

	static ISerializer<SetHudTrackRequest> IFlatBufferSerializable<SetHudTrackRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EProgressiveSerializer;

	static SetHudTrackRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetHudTrackRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetHudTrackRequest()
	{
		CinematicId = null;
		Track = null;
	}

	protected SetHudTrackRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetHudTrackRequest(SetHudTrackRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		Track = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Track);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
