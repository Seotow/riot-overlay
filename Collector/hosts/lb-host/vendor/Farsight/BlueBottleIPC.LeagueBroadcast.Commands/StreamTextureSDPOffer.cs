using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NFF278FF262CF9521A29F970ECFE1E8A93C06FB52EF81A033B419F893CF5121F8;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureSDPOffer")]
public class StreamTextureSDPOffer : IFlatBufferSerializable<StreamTextureSDPOffer>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual AssetIdentifier? Ident { get; set; }

	[FlatBufferItem(2, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string SdpOffer { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<IceServer>? IceServers { get; set; }

	public static ISerializer<StreamTextureSDPOffer> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StreamTextureSDPOffer>)this).Serializer;

	ISerializer<StreamTextureSDPOffer> IFlatBufferSerializable<StreamTextureSDPOffer>.Serializer => Serializer;

	private static readonly ISerializer<StreamTextureSDPOffer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002ELazySerializer;

	static ISerializer<StreamTextureSDPOffer> IFlatBufferSerializable<StreamTextureSDPOffer>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002ELazySerializer;

	private static readonly ISerializer<StreamTextureSDPOffer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedySerializer;

	static ISerializer<StreamTextureSDPOffer> IFlatBufferSerializable<StreamTextureSDPOffer>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedySerializer;

	private static readonly ISerializer<StreamTextureSDPOffer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedyMutableSerializer;

	static ISerializer<StreamTextureSDPOffer> IFlatBufferSerializable<StreamTextureSDPOffer>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StreamTextureSDPOffer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EProgressiveSerializer;

	static ISerializer<StreamTextureSDPOffer> IFlatBufferSerializable<StreamTextureSDPOffer>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EProgressiveSerializer;

	static StreamTextureSDPOffer()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureSDPOffer_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StreamTextureSDPOffer()
	{
		Ident = null;
		IceServers = null;
	}

	protected StreamTextureSDPOffer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StreamTextureSDPOffer(StreamTextureSDPOffer source)
	{
		Ident = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Ident);
		SdpOffer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SdpOffer);
		IceServers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IceServers);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
