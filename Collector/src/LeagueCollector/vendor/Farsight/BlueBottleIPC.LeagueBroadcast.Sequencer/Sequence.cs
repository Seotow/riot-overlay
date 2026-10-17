using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N595B2E7502315F086AB3B99B5188C6C3E700643C4AF9D2D7D33F3C1719C53D87;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true, FileIdentifier = "BBSQ")]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence")]
public class Sequence : IFlatBufferSerializable<Sequence>, IFlatBufferSerializable
{
	[FlatBufferItem(0, DefaultValue = 2)]
	public virtual ushort SchemaVersion { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Id { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(3)]
	public virtual string? SceneName { get; set; }

	[FlatBufferItem(4, DefaultValue = 60f)]
	public virtual float FrameRate { get; set; }

	[FlatBufferItem(5)]
	public virtual IList<Binding>? Bindings { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<Clip>? Clips { get; set; }

	[FlatBufferItem(7)]
	public virtual IList<Exposed>? Exposed { get; set; }

	public static ISerializer<Sequence> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Sequence>)this).Serializer;

	ISerializer<Sequence> IFlatBufferSerializable<Sequence>.Serializer => Serializer;

	private static readonly ISerializer<Sequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002ELazySerializer;

	static ISerializer<Sequence> IFlatBufferSerializable<Sequence>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002ELazySerializer;

	private static readonly ISerializer<Sequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedySerializer;

	static ISerializer<Sequence> IFlatBufferSerializable<Sequence>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedySerializer;

	private static readonly ISerializer<Sequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedyMutableSerializer;

	static ISerializer<Sequence> IFlatBufferSerializable<Sequence>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Sequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EProgressiveSerializer;

	static ISerializer<Sequence> IFlatBufferSerializable<Sequence>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EProgressiveSerializer;

	static Sequence()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequence_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Sequence()
	{
		SchemaVersion = 2;
		Name = null;
		SceneName = null;
		FrameRate = 60f;
		Bindings = null;
		Clips = null;
		Exposed = null;
	}

	protected Sequence(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Sequence(Sequence source)
	{
		SchemaVersion = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SchemaVersion);
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		SceneName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneName);
		FrameRate = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FrameRate);
		Bindings = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Bindings);
		Clips = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Clips);
		Exposed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Exposed);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
