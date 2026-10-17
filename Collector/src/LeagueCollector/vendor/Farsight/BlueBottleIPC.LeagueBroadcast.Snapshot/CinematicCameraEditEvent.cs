using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CinematicCameraEditEvent")]
public class CinematicCameraEditEvent : IFlatBufferSerializable<CinematicCameraEditEvent>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(1)]
	public virtual uint ClipIndex { get; set; }

	[FlatBufferItem(2)]
	public virtual uint TrackIndex { get; set; }

	[FlatBufferItem(3)]
	public virtual uint SectionIndex { get; set; }

	[FlatBufferItem(4)]
	public virtual uint ChannelIndex { get; set; }

	[FlatBufferItem(5)]
	public virtual uint KeyIndex { get; set; }

	[FlatBufferItem(6)]
	public virtual CinematicCameraEditPhase Phase { get; set; }

	[FlatBufferItem(7)]
	public virtual Vector3? Position { get; set; }

	[FlatBufferItem(8)]
	public virtual CinematicCameraEditorHandle Handle { get; set; }

	public static ISerializer<CinematicCameraEditEvent> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicCameraEditEvent>)this).Serializer;

	ISerializer<CinematicCameraEditEvent> IFlatBufferSerializable<CinematicCameraEditEvent>.Serializer => Serializer;

	private static readonly ISerializer<CinematicCameraEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002ELazySerializer;

	static ISerializer<CinematicCameraEditEvent> IFlatBufferSerializable<CinematicCameraEditEvent>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicCameraEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedySerializer;

	static ISerializer<CinematicCameraEditEvent> IFlatBufferSerializable<CinematicCameraEditEvent>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicCameraEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicCameraEditEvent> IFlatBufferSerializable<CinematicCameraEditEvent>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicCameraEditEvent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EProgressiveSerializer;

	static ISerializer<CinematicCameraEditEvent> IFlatBufferSerializable<CinematicCameraEditEvent>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EProgressiveSerializer;

	static CinematicCameraEditEvent()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraEditEvent_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicCameraEditEvent()
	{
		Generation = 0uL;
		ClipIndex = 0u;
		TrackIndex = 0u;
		SectionIndex = 0u;
		ChannelIndex = 0u;
		KeyIndex = 0u;
		Phase = CinematicCameraEditPhase.Selected;
		Position = null;
		Handle = CinematicCameraEditorHandle.Camera;
	}

	protected CinematicCameraEditEvent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicCameraEditEvent(CinematicCameraEditEvent source)
	{
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		ClipIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ClipIndex);
		TrackIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TrackIndex);
		SectionIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SectionIndex);
		ChannelIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChannelIndex);
		KeyIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.KeyIndex);
		Phase = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Phase);
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
		Handle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Handle);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
