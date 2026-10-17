using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC8BCB92545D4FE59D18D5492C3E15DCF9495BB0AACA97222FA214BA02E0B4D4C;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.CameraFocusPoint")]
public class CameraFocusPoint : IFlatBufferSerializable<CameraFocusPoint>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1, DefaultValue = CameraLookAtSource.Channel)]
	public virtual CameraLookAtSource Source { get; set; }

	[FlatBufferItem(2)]
	public virtual uint Binding { get; set; }

	[FlatBufferItem(3)]
	public virtual uint NetworkId { get; set; }

	[FlatBufferItem(4)]
	public virtual CameraLookAtTeam Team { get; set; }

	[FlatBufferItem(5, DefaultValue = 1)]
	public virtual byte TeamPosition { get; set; }

	[FlatBufferItem(6)]
	public virtual CameraLookAtObjective Objective { get; set; }

	[FlatBufferItem(7)]
	public virtual float OffsetX { get; set; }

	[FlatBufferItem(8)]
	public virtual float OffsetY { get; set; }

	[FlatBufferItem(9)]
	public virtual float OffsetZ { get; set; }

	public static ISerializer<CameraFocusPoint> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraFocusPoint>)this).Serializer;

	ISerializer<CameraFocusPoint> IFlatBufferSerializable<CameraFocusPoint>.Serializer => Serializer;

	private static readonly ISerializer<CameraFocusPoint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002ELazySerializer;

	static ISerializer<CameraFocusPoint> IFlatBufferSerializable<CameraFocusPoint>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002ELazySerializer;

	private static readonly ISerializer<CameraFocusPoint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedySerializer;

	static ISerializer<CameraFocusPoint> IFlatBufferSerializable<CameraFocusPoint>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraFocusPoint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraFocusPoint> IFlatBufferSerializable<CameraFocusPoint>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraFocusPoint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EProgressiveSerializer;

	static ISerializer<CameraFocusPoint> IFlatBufferSerializable<CameraFocusPoint>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EProgressiveSerializer;

	static CameraFocusPoint()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraFocusPoint_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraFocusPoint()
	{
		Time = 0f;
		Source = CameraLookAtSource.Channel;
		Binding = 0u;
		NetworkId = 0u;
		Team = CameraLookAtTeam.Blue;
		TeamPosition = 1;
		Objective = CameraLookAtObjective.Grubs;
		OffsetX = 0f;
		OffsetY = 0f;
		OffsetZ = 0f;
	}

	protected CameraFocusPoint(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraFocusPoint(CameraFocusPoint source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Source = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Source);
		Binding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Binding);
		NetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NetworkId);
		Team = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Team);
		TeamPosition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamPosition);
		Objective = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Objective);
		OffsetX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetX);
		OffsetY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetY);
		OffsetZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetZ);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
