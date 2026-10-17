using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF17B30B3E0E9827752011701ADF876C3CCA054054FBDB71EC1BDBDAD87372353;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.AddModelRequest")]
public class AddModelRequest : IFlatBufferSerializable<AddModelRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? ModelAsset { get; set; }

	public static ISerializer<AddModelRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AddModelRequest>)this).Serializer;

	ISerializer<AddModelRequest> IFlatBufferSerializable<AddModelRequest>.Serializer => Serializer;

	private static readonly ISerializer<AddModelRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002ELazySerializer;

	static ISerializer<AddModelRequest> IFlatBufferSerializable<AddModelRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002ELazySerializer;

	private static readonly ISerializer<AddModelRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedySerializer;

	static ISerializer<AddModelRequest> IFlatBufferSerializable<AddModelRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<AddModelRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<AddModelRequest> IFlatBufferSerializable<AddModelRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AddModelRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EProgressiveSerializer;

	static ISerializer<AddModelRequest> IFlatBufferSerializable<AddModelRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EProgressiveSerializer;

	static AddModelRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EAddModelRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AddModelRequest()
	{
		CinematicId = null;
		ModelAsset = null;
	}

	protected AddModelRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AddModelRequest(AddModelRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		ModelAsset = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ModelAsset);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
