using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NCCFFD647267A08A6E34854A3D524449C12CA9A7650D1997A8C7184B712D23282;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Marker")]
public class Marker : IFlatBufferSerializable<Marker>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(2)]
	public virtual MarkerKind Kind { get; set; }

	[FlatBufferItem(3)]
	public virtual bool Retroactive { get; set; }

	[FlatBufferItem(4, DefaultValue = true)]
	public virtual bool EmitOnce { get; set; }

	[FlatBufferItem(5)]
	public virtual float PauseDuration { get; set; }

	public static ISerializer<Marker> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Marker>)this).Serializer;

	ISerializer<Marker> IFlatBufferSerializable<Marker>.Serializer => Serializer;

	private static readonly ISerializer<Marker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002ELazySerializer;

	static ISerializer<Marker> IFlatBufferSerializable<Marker>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002ELazySerializer;

	private static readonly ISerializer<Marker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedySerializer;

	static ISerializer<Marker> IFlatBufferSerializable<Marker>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedySerializer;

	private static readonly ISerializer<Marker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedyMutableSerializer;

	static ISerializer<Marker> IFlatBufferSerializable<Marker>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Marker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EProgressiveSerializer;

	static ISerializer<Marker> IFlatBufferSerializable<Marker>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EProgressiveSerializer;

	static Marker()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EMarker_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Marker()
	{
		Time = 0f;
		Kind = MarkerKind.Tag;
		Retroactive = false;
		EmitOnce = true;
		PauseDuration = 0f;
	}

	protected Marker(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Marker(Marker source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Retroactive = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Retroactive);
		EmitOnce = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EmitOnce);
		PauseDuration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PauseDuration);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
