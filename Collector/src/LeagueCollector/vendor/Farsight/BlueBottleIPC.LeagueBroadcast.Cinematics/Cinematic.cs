using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic")]
public class Cinematic : IFlatBufferSerializable<Cinematic>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Id { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2)]
	public virtual string? CameraSequenceName { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<CinematicProp>? Props { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<CinematicHudTrack>? HudTracks { get; set; }

	[FlatBufferItem(5)]
	public virtual IList<CinematicMarker>? Markers { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<CinematicOverlayTrack>? OverlayTracks { get; set; }

	[FlatBufferItem(7)]
	public virtual bool HideOverlays { get; set; }

	public static ISerializer<Cinematic> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Cinematic>)this).Serializer;

	ISerializer<Cinematic> IFlatBufferSerializable<Cinematic>.Serializer => Serializer;

	private static readonly ISerializer<Cinematic> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002ELazySerializer;

	static ISerializer<Cinematic> IFlatBufferSerializable<Cinematic>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002ELazySerializer;

	private static readonly ISerializer<Cinematic> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedySerializer;

	static ISerializer<Cinematic> IFlatBufferSerializable<Cinematic>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedySerializer;

	private static readonly ISerializer<Cinematic> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedyMutableSerializer;

	static ISerializer<Cinematic> IFlatBufferSerializable<Cinematic>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Cinematic> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EProgressiveSerializer;

	static ISerializer<Cinematic> IFlatBufferSerializable<Cinematic>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EProgressiveSerializer;

	static Cinematic()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematic_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Cinematic()
	{
		Id = null;
		Name = null;
		CameraSequenceName = null;
		Props = null;
		HudTracks = null;
		Markers = null;
		OverlayTracks = null;
		HideOverlays = false;
	}

	protected Cinematic(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Cinematic(Cinematic source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		CameraSequenceName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraSequenceName);
		Props = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Props);
		HudTracks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HudTracks);
		Markers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Markers);
		OverlayTracks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OverlayTracks);
		HideOverlays = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HideOverlays);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
