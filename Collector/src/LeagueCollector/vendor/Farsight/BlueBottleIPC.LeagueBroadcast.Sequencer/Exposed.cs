using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NBE4A1D079F31BCA77416BD648F00F265F641D1CB9538C7C9B7A6C819C47C77F1;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Exposed")]
public class Exposed : IFlatBufferSerializable<Exposed>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ExposedKind Kind { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Label { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Help { get; set; }

	[FlatBufferItem(3)]
	public virtual string? Group { get; set; }

	[FlatBufferItem(4)]
	public virtual string? Clip { get; set; }

	[FlatBufferItem(5)]
	public virtual uint Binding { get; set; }

	[FlatBufferItem(6)]
	public virtual SeqProperty Property { get; set; }

	[FlatBufferItem(7)]
	public virtual IList<ExposedChoice>? Choices { get; set; }

	public static ISerializer<Exposed> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Exposed>)this).Serializer;

	ISerializer<Exposed> IFlatBufferSerializable<Exposed>.Serializer => Serializer;

	private static readonly ISerializer<Exposed> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002ELazySerializer;

	static ISerializer<Exposed> IFlatBufferSerializable<Exposed>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002ELazySerializer;

	private static readonly ISerializer<Exposed> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedySerializer;

	static ISerializer<Exposed> IFlatBufferSerializable<Exposed>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedySerializer;

	private static readonly ISerializer<Exposed> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedyMutableSerializer;

	static ISerializer<Exposed> IFlatBufferSerializable<Exposed>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Exposed> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EProgressiveSerializer;

	static ISerializer<Exposed> IFlatBufferSerializable<Exposed>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EProgressiveSerializer;

	static Exposed()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposed_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Exposed()
	{
		Kind = ExposedKind.ClipDuration;
		Help = null;
		Group = null;
		Clip = null;
		Binding = 0u;
		Property = SeqProperty.TransformPosition;
		Choices = null;
	}

	protected Exposed(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Exposed(Exposed source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Label = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Label);
		Help = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Help);
		Group = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Group);
		Clip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Clip);
		Binding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Binding);
		Property = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Property);
		Choices = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Choices);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
