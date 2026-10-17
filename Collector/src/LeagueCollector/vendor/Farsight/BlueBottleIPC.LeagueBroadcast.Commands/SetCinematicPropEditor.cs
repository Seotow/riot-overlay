using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N6F230B522BBBF1144BE2700AF745FECA8A0194777CEEF1E529BF92BCFC5586C1;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicPropEditor")]
public class SetCinematicPropEditor : IFlatBufferSerializable<SetCinematicPropEditor>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(2)]
	public virtual float Playhead { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<CinematicPropPath>? Paths { get; set; }

	public static ISerializer<SetCinematicPropEditor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetCinematicPropEditor>)this).Serializer;

	ISerializer<SetCinematicPropEditor> IFlatBufferSerializable<SetCinematicPropEditor>.Serializer => Serializer;

	private static readonly ISerializer<SetCinematicPropEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002ELazySerializer;

	static ISerializer<SetCinematicPropEditor> IFlatBufferSerializable<SetCinematicPropEditor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002ELazySerializer;

	private static readonly ISerializer<SetCinematicPropEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedySerializer;

	static ISerializer<SetCinematicPropEditor> IFlatBufferSerializable<SetCinematicPropEditor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedySerializer;

	private static readonly ISerializer<SetCinematicPropEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedyMutableSerializer;

	static ISerializer<SetCinematicPropEditor> IFlatBufferSerializable<SetCinematicPropEditor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetCinematicPropEditor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EProgressiveSerializer;

	static ISerializer<SetCinematicPropEditor> IFlatBufferSerializable<SetCinematicPropEditor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EProgressiveSerializer;

	static SetCinematicPropEditor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCinematicPropEditor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetCinematicPropEditor()
	{
		Enabled = false;
		Generation = 0uL;
		Playhead = 0f;
		Paths = null;
	}

	protected SetCinematicPropEditor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetCinematicPropEditor(SetCinematicPropEditor source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		Playhead = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Playhead);
		Paths = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Paths);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
