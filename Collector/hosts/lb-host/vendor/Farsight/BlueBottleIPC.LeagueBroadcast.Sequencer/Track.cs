using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N6DBF9991D0AE1CE3ED227D7AB772014454D1BC766AA1C077F8CCF50E6408764D;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Track")]
public class Track : IFlatBufferSerializable<Track>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Binding { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<Section>? Sections { get; set; }

	[FlatBufferItem(3)]
	public virtual bool Muted { get; set; }

	[FlatBufferItem(4)]
	public virtual bool Locked { get; set; }

	[FlatBufferItem(5)]
	public virtual CameraLookAtSettings? CameraLookAt { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<CameraFocusPoint>? CameraFocusPoints { get; set; }

	public static ISerializer<Track> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Track>)this).Serializer;

	ISerializer<Track> IFlatBufferSerializable<Track>.Serializer => Serializer;

	private static readonly ISerializer<Track> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002ELazySerializer;

	static ISerializer<Track> IFlatBufferSerializable<Track>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002ELazySerializer;

	private static readonly ISerializer<Track> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedySerializer;

	static ISerializer<Track> IFlatBufferSerializable<Track>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedySerializer;

	private static readonly ISerializer<Track> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedyMutableSerializer;

	static ISerializer<Track> IFlatBufferSerializable<Track>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Track> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EProgressiveSerializer;

	static ISerializer<Track> IFlatBufferSerializable<Track>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EProgressiveSerializer;

	static Track()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ETrack_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Track()
	{
		Name = null;
		Binding = 0u;
		Sections = null;
		Muted = false;
		Locked = false;
		CameraLookAt = null;
		CameraFocusPoints = null;
	}

	protected Track(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Track(Track source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Binding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Binding);
		Sections = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Sections);
		Muted = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Muted);
		Locked = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Locked);
		CameraLookAt = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraLookAt);
		CameraFocusPoints = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraFocusPoints);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
