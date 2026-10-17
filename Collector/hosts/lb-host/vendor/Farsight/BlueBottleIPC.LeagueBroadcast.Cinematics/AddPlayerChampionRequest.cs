using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N841EF5E87629066F28BD240E1D46292CBBD7D8AE8FE2113F1956B88FE4A9FF94;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.AddPlayerChampionRequest")]
public class AddPlayerChampionRequest : IFlatBufferSerializable<AddPlayerChampionRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual TeamSlot TeamSlot { get; set; }

	[FlatBufferItem(2)]
	public virtual PlayerSlot PlayerSlot { get; set; }

	public static ISerializer<AddPlayerChampionRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AddPlayerChampionRequest>)this).Serializer;

	ISerializer<AddPlayerChampionRequest> IFlatBufferSerializable<AddPlayerChampionRequest>.Serializer => Serializer;

	private static readonly ISerializer<AddPlayerChampionRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002ELazySerializer;

	static ISerializer<AddPlayerChampionRequest> IFlatBufferSerializable<AddPlayerChampionRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002ELazySerializer;

	private static readonly ISerializer<AddPlayerChampionRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedySerializer;

	static ISerializer<AddPlayerChampionRequest> IFlatBufferSerializable<AddPlayerChampionRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<AddPlayerChampionRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<AddPlayerChampionRequest> IFlatBufferSerializable<AddPlayerChampionRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AddPlayerChampionRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EProgressiveSerializer;

	static ISerializer<AddPlayerChampionRequest> IFlatBufferSerializable<AddPlayerChampionRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EProgressiveSerializer;

	static AddPlayerChampionRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerChampionRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AddPlayerChampionRequest()
	{
		CinematicId = null;
		TeamSlot = TeamSlot.Team1;
		PlayerSlot = PlayerSlot.Player1;
	}

	protected AddPlayerChampionRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AddPlayerChampionRequest(AddPlayerChampionRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		TeamSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamSlot);
		PlayerSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerSlot);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
