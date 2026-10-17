using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC00C3C927010398235F6646E45C849F4BAF48764DF29AFFC823A3A9560572484;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicList")]
public class CinematicList : IFlatBufferSerializable<CinematicList>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<Cinematic>? Cinematics { get; set; }

	public static ISerializer<CinematicList> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicList>)this).Serializer;

	ISerializer<CinematicList> IFlatBufferSerializable<CinematicList>.Serializer => Serializer;

	private static readonly ISerializer<CinematicList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002ELazySerializer;

	static ISerializer<CinematicList> IFlatBufferSerializable<CinematicList>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedySerializer;

	static ISerializer<CinematicList> IFlatBufferSerializable<CinematicList>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicList> IFlatBufferSerializable<CinematicList>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EProgressiveSerializer;

	static ISerializer<CinematicList> IFlatBufferSerializable<CinematicList>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EProgressiveSerializer;

	static CinematicList()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicList_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicList()
	{
		Cinematics = null;
	}

	protected CinematicList(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicList(CinematicList source)
	{
		Cinematics = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Cinematics);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
