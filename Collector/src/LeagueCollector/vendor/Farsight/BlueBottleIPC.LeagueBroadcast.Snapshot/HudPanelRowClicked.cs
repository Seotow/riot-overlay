using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.HudPanelRowClicked")]
public class HudPanelRowClicked : IFlatBufferSerializable<HudPanelRowClicked>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string RowId { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Generation { get; set; }

	public static ISerializer<HudPanelRowClicked> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudPanelRowClicked>)this).Serializer;

	ISerializer<HudPanelRowClicked> IFlatBufferSerializable<HudPanelRowClicked>.Serializer => Serializer;

	private static readonly ISerializer<HudPanelRowClicked> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002ELazySerializer;

	static ISerializer<HudPanelRowClicked> IFlatBufferSerializable<HudPanelRowClicked>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002ELazySerializer;

	private static readonly ISerializer<HudPanelRowClicked> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedySerializer;

	static ISerializer<HudPanelRowClicked> IFlatBufferSerializable<HudPanelRowClicked>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedySerializer;

	private static readonly ISerializer<HudPanelRowClicked> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedyMutableSerializer;

	static ISerializer<HudPanelRowClicked> IFlatBufferSerializable<HudPanelRowClicked>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudPanelRowClicked> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EProgressiveSerializer;

	static ISerializer<HudPanelRowClicked> IFlatBufferSerializable<HudPanelRowClicked>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EProgressiveSerializer;

	static HudPanelRowClicked()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002EHudPanelRowClicked_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudPanelRowClicked()
	{
		Generation = 0u;
	}

	protected HudPanelRowClicked(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudPanelRowClicked(HudPanelRowClicked source)
	{
		RowId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RowId);
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
