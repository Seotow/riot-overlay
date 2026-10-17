using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NB955AF2715FD853EB5A19540DF214CEA9B5F006ABA36DB29CD1CC94C1363B7FB;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetReplayTime")]
public class SetReplayTime : IFlatBufferSerializable<SetReplayTime>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	public static ISerializer<SetReplayTime> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetReplayTime>)this).Serializer;

	ISerializer<SetReplayTime> IFlatBufferSerializable<SetReplayTime>.Serializer => Serializer;

	private static readonly ISerializer<SetReplayTime> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002ELazySerializer;

	static ISerializer<SetReplayTime> IFlatBufferSerializable<SetReplayTime>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002ELazySerializer;

	private static readonly ISerializer<SetReplayTime> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedySerializer;

	static ISerializer<SetReplayTime> IFlatBufferSerializable<SetReplayTime>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedySerializer;

	private static readonly ISerializer<SetReplayTime> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedyMutableSerializer;

	static ISerializer<SetReplayTime> IFlatBufferSerializable<SetReplayTime>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetReplayTime> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EProgressiveSerializer;

	static ISerializer<SetReplayTime> IFlatBufferSerializable<SetReplayTime>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EProgressiveSerializer;

	static SetReplayTime()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetReplayTime_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetReplayTime()
	{
		Time = 0f;
	}

	protected SetReplayTime(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetReplayTime(SetReplayTime source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
