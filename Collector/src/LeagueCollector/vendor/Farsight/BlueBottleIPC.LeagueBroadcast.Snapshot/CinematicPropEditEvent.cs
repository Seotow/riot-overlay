using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CinematicPropEditEvent")]
public class CinematicPropEditEvent : IFlatBufferSerializable<CinematicPropEditEvent>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(1)]
	public virtual string? PropId { get; set; }

	[FlatBufferItem(2)]
	public virtual uint KeyIndex { get; set; }

	[FlatBufferItem(3)]
	public virtual CinematicPropEditPhase Phase { get; set; }

	[FlatBufferItem(4)]
	public virtual Vector3? Position { get; set; }

	public static ISerializer<CinematicPropEditEvent> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicPropEditEvent>)this).Serializer;

	ISerializer<CinematicPropEditEvent> IFlatBufferSerializable<CinematicPropEditEvent>.Serializer => Serializer;

	private static readonly ISerializer<CinematicPropEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002ELazySerializer;

	static ISerializer<CinematicPropEditEvent> IFlatBufferSerializable<CinematicPropEditEvent>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicPropEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedySerializer;

	static ISerializer<CinematicPropEditEvent> IFlatBufferSerializable<CinematicPropEditEvent>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicPropEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicPropEditEvent> IFlatBufferSerializable<CinematicPropEditEvent>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicPropEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EProgressiveSerializer;

	static ISerializer<CinematicPropEditEvent> IFlatBufferSerializable<CinematicPropEditEvent>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EProgressiveSerializer;

	static CinematicPropEditEvent()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicPropEditEvent_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicPropEditEvent()
	{
		Generation = 0uL;
		PropId = null;
		KeyIndex = 0u;
		Phase = CinematicPropEditPhase.Selected;
		Position = null;
	}

	protected CinematicPropEditEvent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicPropEditEvent(CinematicPropEditEvent source)
	{
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		PropId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PropId);
		KeyIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.KeyIndex);
		Phase = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Phase);
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
