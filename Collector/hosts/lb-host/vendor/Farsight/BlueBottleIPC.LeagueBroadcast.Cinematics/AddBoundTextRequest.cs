using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND923F704DCFB877E1E8AC56FDB24B6BC7E2B63D63E7FDC82484962BB54E4D26C;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest")]
public class AddBoundTextRequest : IFlatBufferSerializable<AddBoundTextRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual BoundTextSource Source { get; set; }

	[FlatBufferItem(2)]
	public virtual TextFormat Format { get; set; }

	[FlatBufferItem(3)]
	public virtual TeamSlot TeamSlot { get; set; }

	[FlatBufferItem(4)]
	public virtual PlayerSlot PlayerSlot { get; set; }

	[FlatBufferItem(5)]
	public virtual bool PlayerBinding { get; set; }

	public static ISerializer<AddBoundTextRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AddBoundTextRequest>)this).Serializer;

	ISerializer<AddBoundTextRequest> IFlatBufferSerializable<AddBoundTextRequest>.Serializer => Serializer;

	private static readonly ISerializer<AddBoundTextRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002ELazySerializer;

	static ISerializer<AddBoundTextRequest> IFlatBufferSerializable<AddBoundTextRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002ELazySerializer;

	private static readonly ISerializer<AddBoundTextRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedySerializer;

	static ISerializer<AddBoundTextRequest> IFlatBufferSerializable<AddBoundTextRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<AddBoundTextRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<AddBoundTextRequest> IFlatBufferSerializable<AddBoundTextRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AddBoundTextRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EProgressiveSerializer;

	static ISerializer<AddBoundTextRequest> IFlatBufferSerializable<AddBoundTextRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EProgressiveSerializer;

	static AddBoundTextRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddBoundTextRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AddBoundTextRequest()
	{
		CinematicId = null;
		Source = BoundTextSource.Team1Name;
		Format = TextFormat.Default;
		TeamSlot = TeamSlot.Team1;
		PlayerSlot = PlayerSlot.Player1;
		PlayerBinding = false;
	}

	protected AddBoundTextRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AddBoundTextRequest(AddBoundTextRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		Source = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Source);
		Format = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Format);
		TeamSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamSlot);
		PlayerSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerSlot);
		PlayerBinding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerBinding);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
