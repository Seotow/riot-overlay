using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC87F26ACA3393D27D8B4CDD426FC2558CB920B3192FE2EC0DAEB37E89B7AEF77;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.HudPanelRow")]
public class HudPanelRow : IFlatBufferSerializable<HudPanelRow>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Id { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Label { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Badge { get; set; }

	[FlatBufferItem(3)]
	public virtual HudPanelRowState State { get; set; }

	public static ISerializer<HudPanelRow> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudPanelRow>)this).Serializer;

	ISerializer<HudPanelRow> IFlatBufferSerializable<HudPanelRow>.Serializer => Serializer;

	private static readonly ISerializer<HudPanelRow> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002ELazySerializer;

	static ISerializer<HudPanelRow> IFlatBufferSerializable<HudPanelRow>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002ELazySerializer;

	private static readonly ISerializer<HudPanelRow> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedySerializer;

	static ISerializer<HudPanelRow> IFlatBufferSerializable<HudPanelRow>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedySerializer;

	private static readonly ISerializer<HudPanelRow> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedyMutableSerializer;

	static ISerializer<HudPanelRow> IFlatBufferSerializable<HudPanelRow>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudPanelRow> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EProgressiveSerializer;

	static ISerializer<HudPanelRow> IFlatBufferSerializable<HudPanelRow>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EProgressiveSerializer;

	static HudPanelRow()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudPanelRow_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudPanelRow()
	{
		Label = null;
		Badge = null;
		State = HudPanelRowState.Normal;
	}

	protected HudPanelRow(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudPanelRow(HudPanelRow source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Label = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Label);
		Badge = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Badge);
		State = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.State);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
