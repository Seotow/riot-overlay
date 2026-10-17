using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N620B7926FCBC3DC617074E94940A05FF4973324C8F2DB78463EAE0A185744F00;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.EphemeralAction")]
public class EphemeralAction : IFlatBufferSerializable<EphemeralAction>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual EphemeralType RequestId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<string>? Params { get; set; }

	public static ISerializer<EphemeralAction> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EphemeralAction>)this).Serializer;

	ISerializer<EphemeralAction> IFlatBufferSerializable<EphemeralAction>.Serializer => Serializer;

	private static readonly ISerializer<EphemeralAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002ELazySerializer;

	static ISerializer<EphemeralAction> IFlatBufferSerializable<EphemeralAction>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002ELazySerializer;

	private static readonly ISerializer<EphemeralAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedySerializer;

	static ISerializer<EphemeralAction> IFlatBufferSerializable<EphemeralAction>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedySerializer;

	private static readonly ISerializer<EphemeralAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedyMutableSerializer;

	static ISerializer<EphemeralAction> IFlatBufferSerializable<EphemeralAction>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EphemeralAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EProgressiveSerializer;

	static ISerializer<EphemeralAction> IFlatBufferSerializable<EphemeralAction>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EProgressiveSerializer;

	static EphemeralAction()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EEphemeralAction_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EphemeralAction()
	{
		RequestId = EphemeralType.Metadata;
		Params = null;
	}

	protected EphemeralAction(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EphemeralAction(EphemeralAction source)
	{
		RequestId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestId);
		Params = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Params);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
