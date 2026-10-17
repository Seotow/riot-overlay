using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0F96D282BE96ED076017A32D3909856FCE6B20D78B845021CCCB69AA49938D57;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.AddPlayerVideoRequest")]
public class AddPlayerVideoRequest : IFlatBufferSerializable<AddPlayerVideoRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual TeamSlot TeamSlot { get; set; }

	[FlatBufferItem(2)]
	public virtual PlayerSlot PlayerSlot { get; set; }

	public static ISerializer<AddPlayerVideoRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AddPlayerVideoRequest>)this).Serializer;

	ISerializer<AddPlayerVideoRequest> IFlatBufferSerializable<AddPlayerVideoRequest>.Serializer => Serializer;

	private static readonly ISerializer<AddPlayerVideoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002ELazySerializer;

	static ISerializer<AddPlayerVideoRequest> IFlatBufferSerializable<AddPlayerVideoRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002ELazySerializer;

	private static readonly ISerializer<AddPlayerVideoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedySerializer;

	static ISerializer<AddPlayerVideoRequest> IFlatBufferSerializable<AddPlayerVideoRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<AddPlayerVideoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<AddPlayerVideoRequest> IFlatBufferSerializable<AddPlayerVideoRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AddPlayerVideoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EProgressiveSerializer;

	static ISerializer<AddPlayerVideoRequest> IFlatBufferSerializable<AddPlayerVideoRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EProgressiveSerializer;

	static AddPlayerVideoRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddPlayerVideoRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AddPlayerVideoRequest()
	{
		CinematicId = null;
		TeamSlot = TeamSlot.Team1;
		PlayerSlot = PlayerSlot.Player1;
	}

	protected AddPlayerVideoRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AddPlayerVideoRequest(AddPlayerVideoRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		TeamSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamSlot);
		PlayerSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerSlot);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
