using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0AF1A3F17D1C4681D7C486B8F668E4CBD149D2078E7965383C4EC9BA5FF04160;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicCameraEditor")]
public class SetCinematicCameraEditor : IFlatBufferSerializable<SetCinematicCameraEditor>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(2)]
	public virtual float Playhead { get; set; }

	[FlatBufferItem(3)]
	public virtual bool HasSelection { get; set; }

	[FlatBufferItem(4)]
	public virtual uint ClipIndex { get; set; }

	[FlatBufferItem(5)]
	public virtual uint TrackIndex { get; set; }

	[FlatBufferItem(6)]
	public virtual uint SectionIndex { get; set; }

	[FlatBufferItem(7)]
	public virtual uint ChannelIndex { get; set; }

	[FlatBufferItem(8)]
	public virtual uint KeyIndex { get; set; }

	[FlatBufferItem(9)]
	public virtual CinematicCameraEditorHandle Handle { get; set; }

	[FlatBufferItem(10)]
	public virtual bool Preview { get; set; }

	public static ISerializer<SetCinematicCameraEditor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetCinematicCameraEditor>)this).Serializer;

	ISerializer<SetCinematicCameraEditor> IFlatBufferSerializable<SetCinematicCameraEditor>.Serializer => Serializer;

	private static readonly ISerializer<SetCinematicCameraEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002ELazySerializer;

	static ISerializer<SetCinematicCameraEditor> IFlatBufferSerializable<SetCinematicCameraEditor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002ELazySerializer;

	private static readonly ISerializer<SetCinematicCameraEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedySerializer;

	static ISerializer<SetCinematicCameraEditor> IFlatBufferSerializable<SetCinematicCameraEditor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedySerializer;

	private static readonly ISerializer<SetCinematicCameraEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedyMutableSerializer;

	static ISerializer<SetCinematicCameraEditor> IFlatBufferSerializable<SetCinematicCameraEditor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetCinematicCameraEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EProgressiveSerializer;

	static ISerializer<SetCinematicCameraEditor> IFlatBufferSerializable<SetCinematicCameraEditor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EProgressiveSerializer;

	static SetCinematicCameraEditor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicCameraEditor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetCinematicCameraEditor()
	{
		Enabled = false;
		Generation = 0uL;
		Playhead = 0f;
		HasSelection = false;
		ClipIndex = 0u;
		TrackIndex = 0u;
		SectionIndex = 0u;
		ChannelIndex = 0u;
		KeyIndex = 0u;
		Handle = CinematicCameraEditorHandle.Camera;
		Preview = false;
	}

	protected SetCinematicCameraEditor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetCinematicCameraEditor(SetCinematicCameraEditor source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		Playhead = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Playhead);
		HasSelection = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HasSelection);
		ClipIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ClipIndex);
		TrackIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TrackIndex);
		SectionIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SectionIndex);
		ChannelIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChannelIndex);
		KeyIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.KeyIndex);
		Handle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Handle);
		Preview = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Preview);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
