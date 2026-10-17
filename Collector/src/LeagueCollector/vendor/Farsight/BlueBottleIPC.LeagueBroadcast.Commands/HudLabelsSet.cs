using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N212326A40EC8B86BE27B02E1773E65E8AE15E8FD76CB45609E0F1B3353F013A7;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.HudLabelsSet")]
public class HudLabelsSet : IFlatBufferSerializable<HudLabelsSet>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint Generation { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<HudLabel>? Labels { get; set; }

	public static ISerializer<HudLabelsSet> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudLabelsSet>)this).Serializer;

	ISerializer<HudLabelsSet> IFlatBufferSerializable<HudLabelsSet>.Serializer => Serializer;

	private static readonly ISerializer<HudLabelsSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002ELazySerializer;

	static ISerializer<HudLabelsSet> IFlatBufferSerializable<HudLabelsSet>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002ELazySerializer;

	private static readonly ISerializer<HudLabelsSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedySerializer;

	static ISerializer<HudLabelsSet> IFlatBufferSerializable<HudLabelsSet>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedySerializer;

	private static readonly ISerializer<HudLabelsSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedyMutableSerializer;

	static ISerializer<HudLabelsSet> IFlatBufferSerializable<HudLabelsSet>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudLabelsSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EProgressiveSerializer;

	static ISerializer<HudLabelsSet> IFlatBufferSerializable<HudLabelsSet>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EProgressiveSerializer;

	static HudLabelsSet()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabelsSet_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudLabelsSet()
	{
		Generation = 0u;
		Labels = null;
	}

	protected HudLabelsSet(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudLabelsSet(HudLabelsSet source)
	{
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		Labels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Labels);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
