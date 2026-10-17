using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0F25F7EE51D372BB74D4F44F8EB985DE75CDF95786C546636CAD10AA76623910;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.RegisterService")]
public class RegisterService : IFlatBufferSerializable<RegisterService>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ServiceType Type { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<string>? Params { get; set; }

	public static ISerializer<RegisterService> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<RegisterService>)this).Serializer;

	ISerializer<RegisterService> IFlatBufferSerializable<RegisterService>.Serializer => Serializer;

	private static readonly ISerializer<RegisterService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002ELazySerializer;

	static ISerializer<RegisterService> IFlatBufferSerializable<RegisterService>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002ELazySerializer;

	private static readonly ISerializer<RegisterService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedySerializer;

	static ISerializer<RegisterService> IFlatBufferSerializable<RegisterService>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedySerializer;

	private static readonly ISerializer<RegisterService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedyMutableSerializer;

	static ISerializer<RegisterService> IFlatBufferSerializable<RegisterService>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<RegisterService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EProgressiveSerializer;

	static ISerializer<RegisterService> IFlatBufferSerializable<RegisterService>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EProgressiveSerializer;

	static RegisterService()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ERegisterService_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public RegisterService()
	{
		Type = ServiceType.ZenosLiveSnapshot;
		Params = null;
	}

	protected RegisterService(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public RegisterService(RegisterService source)
	{
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		Params = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Params);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
