using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA4D1033DC4EABD4463D9A364C762A0BB160B9CA1523EDEFA0F59641566C9106C;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.AddLogoRequest")]
public class AddLogoRequest : IFlatBufferSerializable<AddLogoRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual TeamSlot TeamSlot { get; set; }

	[FlatBufferItem(2)]
	public virtual PlayerSlot PlayerSlot { get; set; }

	[FlatBufferItem(3)]
	public virtual bool PlayerBinding { get; set; }

	public static ISerializer<AddLogoRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AddLogoRequest>)this).Serializer;

	ISerializer<AddLogoRequest> IFlatBufferSerializable<AddLogoRequest>.Serializer => Serializer;

	private static readonly ISerializer<AddLogoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002ELazySerializer;

	static ISerializer<AddLogoRequest> IFlatBufferSerializable<AddLogoRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002ELazySerializer;

	private static readonly ISerializer<AddLogoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedySerializer;

	static ISerializer<AddLogoRequest> IFlatBufferSerializable<AddLogoRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<AddLogoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<AddLogoRequest> IFlatBufferSerializable<AddLogoRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AddLogoRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EProgressiveSerializer;

	static ISerializer<AddLogoRequest> IFlatBufferSerializable<AddLogoRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EProgressiveSerializer;

	static AddLogoRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddLogoRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AddLogoRequest()
	{
		CinematicId = null;
		TeamSlot = TeamSlot.Team1;
		PlayerSlot = PlayerSlot.Player1;
		PlayerBinding = false;
	}

	protected AddLogoRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AddLogoRequest(AddLogoRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		TeamSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamSlot);
		PlayerSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerSlot);
		PlayerBinding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerBinding);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
