using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N2DC6149A3A96106A213058ED7AA5DB4BE11A0A61D418F81C9193732BD993054D;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.SeqKeyframe")]
public class SeqKeyframe : IFlatBufferSerializable<SeqKeyframe>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1)]
	public virtual float X { get; set; }

	[FlatBufferItem(2)]
	public virtual float Y { get; set; }

	[FlatBufferItem(3)]
	public virtual float Z { get; set; }

	[FlatBufferItem(4)]
	public virtual float FloatValue { get; set; }

	[FlatBufferItem(5)]
	public virtual bool BoolValue { get; set; }

	[FlatBufferItem(6)]
	public virtual BlendEasing Easing { get; set; }

	[FlatBufferItem(7)]
	public virtual CameraTangentMode TangentMode { get; set; }

	[FlatBufferItem(8)]
	public virtual float TangentX { get; set; }

	[FlatBufferItem(9)]
	public virtual float TangentY { get; set; }

	[FlatBufferItem(10)]
	public virtual float TangentZ { get; set; }

	[FlatBufferItem(11)]
	public virtual bool TangentsSplit { get; set; }

	[FlatBufferItem(12)]
	public virtual float IncomingTangentX { get; set; }

	[FlatBufferItem(13)]
	public virtual float IncomingTangentY { get; set; }

	[FlatBufferItem(14)]
	public virtual float IncomingTangentZ { get; set; }

	public static ISerializer<SeqKeyframe> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SeqKeyframe>)this).Serializer;

	ISerializer<SeqKeyframe> IFlatBufferSerializable<SeqKeyframe>.Serializer => Serializer;

	private static readonly ISerializer<SeqKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002ELazySerializer;

	static ISerializer<SeqKeyframe> IFlatBufferSerializable<SeqKeyframe>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002ELazySerializer;

	private static readonly ISerializer<SeqKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedySerializer;

	static ISerializer<SeqKeyframe> IFlatBufferSerializable<SeqKeyframe>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedySerializer;

	private static readonly ISerializer<SeqKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedyMutableSerializer;

	static ISerializer<SeqKeyframe> IFlatBufferSerializable<SeqKeyframe>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SeqKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EProgressiveSerializer;

	static ISerializer<SeqKeyframe> IFlatBufferSerializable<SeqKeyframe>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EProgressiveSerializer;

	static SeqKeyframe()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESeqKeyframe_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SeqKeyframe()
	{
		Time = 0f;
		X = 0f;
		Y = 0f;
		Z = 0f;
		FloatValue = 0f;
		BoolValue = false;
		Easing = BlendEasing.Linear;
		TangentMode = CameraTangentMode.Auto;
		TangentX = 0f;
		TangentY = 0f;
		TangentZ = 0f;
		TangentsSplit = false;
		IncomingTangentX = 0f;
		IncomingTangentY = 0f;
		IncomingTangentZ = 0f;
	}

	protected SeqKeyframe(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SeqKeyframe(SeqKeyframe source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		X = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.X);
		Y = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Y);
		Z = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Z);
		FloatValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FloatValue);
		BoolValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BoolValue);
		Easing = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Easing);
		TangentMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TangentMode);
		TangentX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TangentX);
		TangentY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TangentY);
		TangentZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TangentZ);
		TangentsSplit = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TangentsSplit);
		IncomingTangentX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IncomingTangentX);
		IncomingTangentY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IncomingTangentY);
		IncomingTangentZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IncomingTangentZ);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
