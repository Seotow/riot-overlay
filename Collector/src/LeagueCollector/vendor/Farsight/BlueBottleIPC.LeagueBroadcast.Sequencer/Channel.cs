using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NEAC7B00EF46C0E9A9FF8CE2227C63A6CAB14C5CDA4E7D4D51843D3F790613D82;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Channel")]
public class Channel : IFlatBufferSerializable<Channel>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual SeqProperty Property { get; set; }

	[FlatBufferItem(1)]
	public virtual ChannelValue Value { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<SeqKeyframe>? Keys { get; set; }

	public static ISerializer<Channel> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Channel>)this).Serializer;

	ISerializer<Channel> IFlatBufferSerializable<Channel>.Serializer => Serializer;

	private static readonly ISerializer<Channel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002ELazySerializer;

	static ISerializer<Channel> IFlatBufferSerializable<Channel>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002ELazySerializer;

	private static readonly ISerializer<Channel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedySerializer;

	static ISerializer<Channel> IFlatBufferSerializable<Channel>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedySerializer;

	private static readonly ISerializer<Channel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedyMutableSerializer;

	static ISerializer<Channel> IFlatBufferSerializable<Channel>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Channel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EProgressiveSerializer;

	static ISerializer<Channel> IFlatBufferSerializable<Channel>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EProgressiveSerializer;

	static Channel()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EChannel_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Channel()
	{
		Property = SeqProperty.TransformPosition;
		Value = ChannelValue.Scalar;
		Keys = null;
	}

	protected Channel(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Channel(Channel source)
	{
		Property = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Property);
		Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Value);
		Keys = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Keys);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
