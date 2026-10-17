using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N2AF1A791125ED9F75D94B434B214688FDA256133613A7F2B0BF9B480C62E664B;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Response")]
public class Response : IFlatBufferSerializable<Response>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ResponseKind Data { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong RequestId { get; set; }

	public static ISerializer<Response> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Response>)this).Serializer;

	ISerializer<Response> IFlatBufferSerializable<Response>.Serializer => Serializer;

	private static readonly ISerializer<Response> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002ELazySerializer;

	static ISerializer<Response> IFlatBufferSerializable<Response>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002ELazySerializer;

	private static readonly ISerializer<Response> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedySerializer;

	static ISerializer<Response> IFlatBufferSerializable<Response>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedySerializer;

	private static readonly ISerializer<Response> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedyMutableSerializer;

	static ISerializer<Response> IFlatBufferSerializable<Response>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Response> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EProgressiveSerializer;

	static ISerializer<Response> IFlatBufferSerializable<Response>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EProgressiveSerializer;

	static Response()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EResponse_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Response()
	{
		RequestId = 0uL;
	}

	protected Response(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Response(Response source)
	{
		Data = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Data);
		RequestId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
