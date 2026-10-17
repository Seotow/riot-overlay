using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NBD230692E9F2CC67A7E193849D97DD314B16FE6AE01076A67F2CEE96DABD9888;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.Request")]
public class Request : IFlatBufferSerializable<Request>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual RequestKind? Data { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong RequestId { get; set; }

	public static ISerializer<Request> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Request>)this).Serializer;

	ISerializer<Request> IFlatBufferSerializable<Request>.Serializer => Serializer;

	private static readonly ISerializer<Request> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002ELazySerializer;

	static ISerializer<Request> IFlatBufferSerializable<Request>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002ELazySerializer;

	private static readonly ISerializer<Request> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedySerializer;

	static ISerializer<Request> IFlatBufferSerializable<Request>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedySerializer;

	private static readonly ISerializer<Request> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedyMutableSerializer;

	static ISerializer<Request> IFlatBufferSerializable<Request>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Request> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EProgressiveSerializer;

	static ISerializer<Request> IFlatBufferSerializable<Request>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EProgressiveSerializer;

	static Request()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Request()
	{
		Data = null;
		RequestId = 0uL;
	}

	protected Request(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Request(Request source)
	{
		Data = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Data);
		RequestId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
