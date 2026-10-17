using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncCurrent")]
public class StrokeSyncCurrent : IFlatBufferSerializable<StrokeSyncCurrent>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<CompletedStroke>? CompletedStrokes { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<StrokeSyncBeginRemote>? InProgressStrokes { get; set; }

	public static ISerializer<StrokeSyncCurrent> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSyncCurrent>)this).Serializer;

	ISerializer<StrokeSyncCurrent> IFlatBufferSerializable<StrokeSyncCurrent>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSyncCurrent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002ELazySerializer;

	static ISerializer<StrokeSyncCurrent> IFlatBufferSerializable<StrokeSyncCurrent>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSyncCurrent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedySerializer;

	static ISerializer<StrokeSyncCurrent> IFlatBufferSerializable<StrokeSyncCurrent>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSyncCurrent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSyncCurrent> IFlatBufferSerializable<StrokeSyncCurrent>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSyncCurrent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSyncCurrent> IFlatBufferSerializable<StrokeSyncCurrent>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EProgressiveSerializer;

	static StrokeSyncCurrent()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncCurrent_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSyncCurrent()
	{
		CompletedStrokes = null;
		InProgressStrokes = null;
	}

	protected StrokeSyncCurrent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSyncCurrent(StrokeSyncCurrent source)
	{
		CompletedStrokes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CompletedStrokes);
		InProgressStrokes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InProgressStrokes);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
