using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA4D99726554D3A6ACF49AB7FEC7840D0E3A2A4C776E7151F2852DA6146FD4102;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.ExposedChoice")]
public class ExposedChoice : IFlatBufferSerializable<ExposedChoice>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Label { get; set; }

	[FlatBufferItem(1)]
	public virtual float Value { get; set; }

	public static ISerializer<ExposedChoice> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ExposedChoice>)this).Serializer;

	ISerializer<ExposedChoice> IFlatBufferSerializable<ExposedChoice>.Serializer => Serializer;

	private static readonly ISerializer<ExposedChoice> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002ELazySerializer;

	static ISerializer<ExposedChoice> IFlatBufferSerializable<ExposedChoice>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002ELazySerializer;

	private static readonly ISerializer<ExposedChoice> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedySerializer;

	static ISerializer<ExposedChoice> IFlatBufferSerializable<ExposedChoice>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedySerializer;

	private static readonly ISerializer<ExposedChoice> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedyMutableSerializer;

	static ISerializer<ExposedChoice> IFlatBufferSerializable<ExposedChoice>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ExposedChoice> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EProgressiveSerializer;

	static ISerializer<ExposedChoice> IFlatBufferSerializable<ExposedChoice>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EProgressiveSerializer;

	static ExposedChoice()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EExposedChoice_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ExposedChoice()
	{
		Value = 0f;
	}

	protected ExposedChoice(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ExposedChoice(ExposedChoice source)
	{
		Label = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Label);
		Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Value);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
