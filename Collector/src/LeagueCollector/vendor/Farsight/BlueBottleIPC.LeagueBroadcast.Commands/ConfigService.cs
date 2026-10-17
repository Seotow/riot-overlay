using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N7AC71D637805F061F01BB4E59C1A93D17FFD174DA65128C7A68377ECAA509D41;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.ConfigService")]
public class ConfigService : IFlatBufferSerializable<ConfigService>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ServiceType Type { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<string>? Params { get; set; }

	public static ISerializer<ConfigService> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ConfigService>)this).Serializer;

	ISerializer<ConfigService> IFlatBufferSerializable<ConfigService>.Serializer => Serializer;

	private static readonly ISerializer<ConfigService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002ELazySerializer;

	static ISerializer<ConfigService> IFlatBufferSerializable<ConfigService>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002ELazySerializer;

	private static readonly ISerializer<ConfigService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedySerializer;

	static ISerializer<ConfigService> IFlatBufferSerializable<ConfigService>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedySerializer;

	private static readonly ISerializer<ConfigService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedyMutableSerializer;

	static ISerializer<ConfigService> IFlatBufferSerializable<ConfigService>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ConfigService> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EProgressiveSerializer;

	static ISerializer<ConfigService> IFlatBufferSerializable<ConfigService>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EProgressiveSerializer;

	static ConfigService()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EConfigService_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ConfigService()
	{
		Type = ServiceType.ZenosLiveSnapshot;
		Params = null;
	}

	protected ConfigService(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ConfigService(ConfigService source)
	{
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		Params = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Params);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
