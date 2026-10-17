using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8B0B1A25F0349ABF29D12FCDB9D2040FE550632A13DDA0B2518A38531AC5A368;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.HudPanelSet")]
public class HudPanelSet : IFlatBufferSerializable<HudPanelSet>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Visible { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Title { get; set; }

	[FlatBufferItem(2)]
	public virtual float AnchorX { get; set; }

	[FlatBufferItem(3)]
	public virtual float AnchorY { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<HudPanelRow>? Rows { get; set; }

	[FlatBufferItem(5)]
	public virtual uint Generation { get; set; }

	[FlatBufferItem(6)]
	public virtual HudPanelAlignX AlignX { get; set; }

	[FlatBufferItem(7)]
	public virtual HudPanelAlignY AlignY { get; set; }

	[FlatBufferItem(8)]
	public virtual string? ConfirmHelper { get; set; }

	public static ISerializer<HudPanelSet> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudPanelSet>)this).Serializer;

	ISerializer<HudPanelSet> IFlatBufferSerializable<HudPanelSet>.Serializer => Serializer;

	private static readonly ISerializer<HudPanelSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002ELazySerializer;

	static ISerializer<HudPanelSet> IFlatBufferSerializable<HudPanelSet>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002ELazySerializer;

	private static readonly ISerializer<HudPanelSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedySerializer;

	static ISerializer<HudPanelSet> IFlatBufferSerializable<HudPanelSet>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedySerializer;

	private static readonly ISerializer<HudPanelSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedyMutableSerializer;

	static ISerializer<HudPanelSet> IFlatBufferSerializable<HudPanelSet>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudPanelSet> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EProgressiveSerializer;

	static ISerializer<HudPanelSet> IFlatBufferSerializable<HudPanelSet>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EProgressiveSerializer;

	static HudPanelSet()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelSet_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudPanelSet()
	{
		Visible = false;
		Title = null;
		AnchorX = 0f;
		AnchorY = 0f;
		Rows = null;
		Generation = 0u;
		AlignX = HudPanelAlignX.left;
		AlignY = HudPanelAlignY.top;
		ConfirmHelper = null;
	}

	protected HudPanelSet(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudPanelSet(HudPanelSet source)
	{
		Visible = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Visible);
		Title = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Title);
		AnchorX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorX);
		AnchorY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnchorY);
		Rows = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rows);
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		AlignX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AlignX);
		AlignY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AlignY);
		ConfirmHelper = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ConfirmHelper);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
