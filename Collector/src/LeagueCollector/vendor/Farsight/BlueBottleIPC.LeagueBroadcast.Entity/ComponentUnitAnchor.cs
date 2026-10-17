using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentUnitAnchor")]
public class ComponentUnitAnchor : IFlatBufferSerializable<ComponentUnitAnchor>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint NetworkId { get; set; }

	[FlatBufferItem(1, DefaultValue = true)]
	public virtual bool RelativeTransform { get; set; }

	[FlatBufferItem(2)]
	public virtual UnitAnchorTargetType TargetType { get; set; }

	[FlatBufferItem(3)]
	public virtual UnitAnchorTeam Team { get; set; }

	[FlatBufferItem(4, DefaultValue = 1)]
	public virtual byte TeamPosition { get; set; }

	[FlatBufferItem(5)]
	public virtual UnitAnchorObjective Objective { get; set; }

	public static ISerializer<ComponentUnitAnchor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentUnitAnchor>)this).Serializer;

	ISerializer<ComponentUnitAnchor> IFlatBufferSerializable<ComponentUnitAnchor>.Serializer => Serializer;

	private static readonly ISerializer<ComponentUnitAnchor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002ELazySerializer;

	static ISerializer<ComponentUnitAnchor> IFlatBufferSerializable<ComponentUnitAnchor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentUnitAnchor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedySerializer;

	static ISerializer<ComponentUnitAnchor> IFlatBufferSerializable<ComponentUnitAnchor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentUnitAnchor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentUnitAnchor> IFlatBufferSerializable<ComponentUnitAnchor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentUnitAnchor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EProgressiveSerializer;

	static ISerializer<ComponentUnitAnchor> IFlatBufferSerializable<ComponentUnitAnchor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EProgressiveSerializer;

	static ComponentUnitAnchor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentUnitAnchor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentUnitAnchor()
	{
		NetworkId = 0u;
		RelativeTransform = true;
		TargetType = UnitAnchorTargetType.NetworkId;
		Team = UnitAnchorTeam.Blue;
		TeamPosition = 1;
		Objective = UnitAnchorObjective.Grubs;
	}

	protected ComponentUnitAnchor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentUnitAnchor(ComponentUnitAnchor source)
	{
		NetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NetworkId);
		RelativeTransform = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RelativeTransform);
		TargetType = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetType);
		Team = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Team);
		TeamPosition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamPosition);
		Objective = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Objective);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
