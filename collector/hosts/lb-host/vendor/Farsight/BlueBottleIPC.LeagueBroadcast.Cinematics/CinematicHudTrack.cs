using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5164B6F8876BDC418E0E4252FDA8D6CD37757EA8CE90D5E7492745068759B023;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicHudTrack")]
public class CinematicHudTrack : IFlatBufferSerializable<CinematicHudTrack>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual CinematicHudElement Element { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<CinematicKeyframe>? Keys { get; set; }

	public static ISerializer<CinematicHudTrack> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicHudTrack>)this).Serializer;

	ISerializer<CinematicHudTrack> IFlatBufferSerializable<CinematicHudTrack>.Serializer => Serializer;

	private static readonly ISerializer<CinematicHudTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002ELazySerializer;

	static ISerializer<CinematicHudTrack> IFlatBufferSerializable<CinematicHudTrack>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicHudTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedySerializer;

	static ISerializer<CinematicHudTrack> IFlatBufferSerializable<CinematicHudTrack>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicHudTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicHudTrack> IFlatBufferSerializable<CinematicHudTrack>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicHudTrack> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EProgressiveSerializer;

	static ISerializer<CinematicHudTrack> IFlatBufferSerializable<CinematicHudTrack>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EProgressiveSerializer;

	static CinematicHudTrack()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicHudTrack_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicHudTrack()
	{
		Element = CinematicHudElement.FloatingText;
		Keys = null;
	}

	protected CinematicHudTrack(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicHudTrack(CinematicHudTrack source)
	{
		Element = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Element);
		Keys = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Keys);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
