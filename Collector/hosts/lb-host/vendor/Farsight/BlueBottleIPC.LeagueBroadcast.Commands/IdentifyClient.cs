using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NEFCB46116F3E015A603F273BE2F613DB8382885A39E0A849AAC0FD1E84861A52;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.IdentifyClient")]
public class IdentifyClient : IFlatBufferSerializable<IdentifyClient>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? AppId { get; set; }

	public static ISerializer<IdentifyClient> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<IdentifyClient>)this).Serializer;

	ISerializer<IdentifyClient> IFlatBufferSerializable<IdentifyClient>.Serializer => Serializer;

	private static readonly ISerializer<IdentifyClient> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002ELazySerializer;

	static ISerializer<IdentifyClient> IFlatBufferSerializable<IdentifyClient>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002ELazySerializer;

	private static readonly ISerializer<IdentifyClient> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedySerializer;

	static ISerializer<IdentifyClient> IFlatBufferSerializable<IdentifyClient>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedySerializer;

	private static readonly ISerializer<IdentifyClient> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedyMutableSerializer;

	static ISerializer<IdentifyClient> IFlatBufferSerializable<IdentifyClient>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<IdentifyClient> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EProgressiveSerializer;

	static ISerializer<IdentifyClient> IFlatBufferSerializable<IdentifyClient>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EProgressiveSerializer;

	static IdentifyClient()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EIdentifyClient_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public IdentifyClient()
	{
		AppId = null;
	}

	protected IdentifyClient(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public IdentifyClient(IdentifyClient source)
	{
		AppId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AppId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
