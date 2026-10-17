using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp")]
public class CinematicProp : IFlatBufferSerializable<CinematicProp>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Id { get; set; }

	[FlatBufferItem(1)]
	public virtual PropKind Kind { get; set; }

	[FlatBufferItem(2)]
	public virtual BoundTextSource Source { get; set; }

	[FlatBufferItem(3)]
	public virtual TextFormat Format { get; set; }

	[FlatBufferItem(4)]
	public virtual TeamSlot TeamSlot { get; set; }

	[FlatBufferItem(5)]
	public virtual IList<CinematicTrack>? Tracks { get; set; }

	[FlatBufferItem(6)]
	public virtual PropStyle? Style { get; set; }

	[FlatBufferItem(7)]
	public virtual PlayerSlot PlayerSlot { get; set; }

	[FlatBufferItem(8)]
	public virtual string? ModelAsset { get; set; }

	public static ISerializer<CinematicProp> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicProp>)this).Serializer;

	ISerializer<CinematicProp> IFlatBufferSerializable<CinematicProp>.Serializer => Serializer;

	private static readonly ISerializer<CinematicProp> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002ELazySerializer;

	static ISerializer<CinematicProp> IFlatBufferSerializable<CinematicProp>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicProp> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedySerializer;

	static ISerializer<CinematicProp> IFlatBufferSerializable<CinematicProp>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicProp> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicProp> IFlatBufferSerializable<CinematicProp>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicProp> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EProgressiveSerializer;

	static ISerializer<CinematicProp> IFlatBufferSerializable<CinematicProp>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EProgressiveSerializer;

	static CinematicProp()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicProp_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicProp()
	{
		Id = null;
		Kind = PropKind.BoundText;
		Source = BoundTextSource.Team1Name;
		Format = TextFormat.Default;
		TeamSlot = TeamSlot.Team1;
		Tracks = null;
		Style = null;
		PlayerSlot = PlayerSlot.Player1;
		ModelAsset = null;
	}

	protected CinematicProp(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicProp(CinematicProp source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Source = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Source);
		Format = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Format);
		TeamSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamSlot);
		Tracks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Tracks);
		Style = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Style);
		PlayerSlot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayerSlot);
		ModelAsset = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ModelAsset);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
