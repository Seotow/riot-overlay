using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N7771A6658C4D856B11D0BFC36EEBCF2637BD41A00C300097D557990163B85E38;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Clip")]
public class Clip : IFlatBufferSerializable<Clip>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual float Duration { get; set; }

	[FlatBufferItem(2)]
	public virtual float InEnd { get; set; }

	[FlatBufferItem(3)]
	public virtual float OutStart { get; set; }

	[FlatBufferItem(4)]
	public virtual bool LoopHold { get; set; }

	[FlatBufferItem(5)]
	public virtual string? LogicLayer { get; set; }

	[FlatBufferItem(6)]
	public virtual string? CameraSequenceName { get; set; }

	[FlatBufferItem(7)]
	public virtual bool AutoStart { get; set; }

	[FlatBufferItem(8)]
	public virtual IList<Track>? Tracks { get; set; }

	[FlatBufferItem(9)]
	public virtual IList<Marker>? Markers { get; set; }

	public static ISerializer<Clip> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Clip>)this).Serializer;

	ISerializer<Clip> IFlatBufferSerializable<Clip>.Serializer => Serializer;

	private static readonly ISerializer<Clip> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002ELazySerializer;

	static ISerializer<Clip> IFlatBufferSerializable<Clip>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002ELazySerializer;

	private static readonly ISerializer<Clip> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedySerializer;

	static ISerializer<Clip> IFlatBufferSerializable<Clip>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedySerializer;

	private static readonly ISerializer<Clip> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedyMutableSerializer;

	static ISerializer<Clip> IFlatBufferSerializable<Clip>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Clip> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EProgressiveSerializer;

	static ISerializer<Clip> IFlatBufferSerializable<Clip>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EProgressiveSerializer;

	static Clip()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EClip_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Clip()
	{
		Duration = 0f;
		InEnd = 0f;
		OutStart = 0f;
		LoopHold = false;
		LogicLayer = null;
		CameraSequenceName = null;
		AutoStart = false;
		Tracks = null;
		Markers = null;
	}

	protected Clip(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Clip(Clip source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Duration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Duration);
		InEnd = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InEnd);
		OutStart = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OutStart);
		LoopHold = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LoopHold);
		LogicLayer = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LogicLayer);
		CameraSequenceName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraSequenceName);
		AutoStart = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AutoStart);
		Tracks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Tracks);
		Markers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Markers);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
