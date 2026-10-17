using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8767B76191F5265A9B288835E01ABDF43EA7A27245F0977DB138462E6F0A5E49;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicTrack")]
public class CinematicTrack : IFlatBufferSerializable<CinematicTrack>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual TrackKind Kind { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<CinematicKeyframe>? Keys { get; set; }

	public static ISerializer<CinematicTrack> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicTrack>)this).Serializer;

	ISerializer<CinematicTrack> IFlatBufferSerializable<CinematicTrack>.Serializer => Serializer;

	private static readonly ISerializer<CinematicTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002ELazySerializer;

	static ISerializer<CinematicTrack> IFlatBufferSerializable<CinematicTrack>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedySerializer;

	static ISerializer<CinematicTrack> IFlatBufferSerializable<CinematicTrack>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicTrack> IFlatBufferSerializable<CinematicTrack>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EProgressiveSerializer;

	static ISerializer<CinematicTrack> IFlatBufferSerializable<CinematicTrack>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EProgressiveSerializer;

	static CinematicTrack()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicTrack_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicTrack()
	{
		Kind = TrackKind.Position;
		Keys = null;
	}

	protected CinematicTrack(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicTrack(CinematicTrack source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Keys = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Keys);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
