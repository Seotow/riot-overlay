using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.HudPanelRowsReordered")]
public class HudPanelRowsReordered : IFlatBufferSerializable<HudPanelRowsReordered>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<string>? RowIds { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Generation { get; set; }

	public static ISerializer<HudPanelRowsReordered> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudPanelRowsReordered>)this).Serializer;

	ISerializer<HudPanelRowsReordered> IFlatBufferSerializable<HudPanelRowsReordered>.Serializer => Serializer;

	private static readonly ISerializer<HudPanelRowsReordered> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002ELazySerializer;

	static ISerializer<HudPanelRowsReordered> IFlatBufferSerializable<HudPanelRowsReordered>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002ELazySerializer;

	private static readonly ISerializer<HudPanelRowsReordered> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedySerializer;

	static ISerializer<HudPanelRowsReordered> IFlatBufferSerializable<HudPanelRowsReordered>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedySerializer;

	private static readonly ISerializer<HudPanelRowsReordered> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedyMutableSerializer;

	static ISerializer<HudPanelRowsReordered> IFlatBufferSerializable<HudPanelRowsReordered>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudPanelRowsReordered> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EProgressiveSerializer;

	static ISerializer<HudPanelRowsReordered> IFlatBufferSerializable<HudPanelRowsReordered>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EProgressiveSerializer;

	static HudPanelRowsReordered()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowsReordered_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudPanelRowsReordered()
	{
		RowIds = null;
		Generation = 0u;
	}

	protected HudPanelRowsReordered(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudPanelRowsReordered(HudPanelRowsReordered source)
	{
		RowIds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RowIds);
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
