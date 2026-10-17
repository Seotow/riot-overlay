using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N835770674D9CC31E7E5211169D9DA0B862ED4C9325F09C793690BE6C452C86C3;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Section")]
public class Section : IFlatBufferSerializable<Section>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Start { get; set; }

	[FlatBufferItem(1)]
	public virtual float End { get; set; }

	[FlatBufferItem(2)]
	public virtual SectionBlend Blend { get; set; }

	[FlatBufferItem(3, DefaultValue = Extrapolation.Hold)]
	public virtual Extrapolation Extrapolation { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<SeqKeyframe>? Influence { get; set; }

	[FlatBufferItem(5)]
	public virtual float EaseIn { get; set; }

	[FlatBufferItem(6)]
	public virtual float EaseOut { get; set; }

	[FlatBufferItem(7, DefaultValue = BlendEasing.SmoothStep)]
	public virtual BlendEasing EaseInCurve { get; set; }

	[FlatBufferItem(8, DefaultValue = BlendEasing.SmoothStep)]
	public virtual BlendEasing EaseOutCurve { get; set; }

	[FlatBufferItem(9)]
	public virtual bool Muted { get; set; }

	[FlatBufferItem(10)]
	public virtual IList<Channel>? Channels { get; set; }

	public static ISerializer<Section> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Section>)this).Serializer;

	ISerializer<Section> IFlatBufferSerializable<Section>.Serializer => Serializer;

	private static readonly ISerializer<Section> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002ELazySerializer;

	static ISerializer<Section> IFlatBufferSerializable<Section>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002ELazySerializer;

	private static readonly ISerializer<Section> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedySerializer;

	static ISerializer<Section> IFlatBufferSerializable<Section>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedySerializer;

	private static readonly ISerializer<Section> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedyMutableSerializer;

	static ISerializer<Section> IFlatBufferSerializable<Section>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Section> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EProgressiveSerializer;

	static ISerializer<Section> IFlatBufferSerializable<Section>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EProgressiveSerializer;

	static Section()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESection_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Section()
	{
		Start = 0f;
		End = 0f;
		Blend = SectionBlend.Replace;
		Extrapolation = Extrapolation.Hold;
		Influence = null;
		EaseIn = 0f;
		EaseOut = 0f;
		EaseInCurve = BlendEasing.SmoothStep;
		EaseOutCurve = BlendEasing.SmoothStep;
		Muted = false;
		Channels = null;
	}

	protected Section(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Section(Section source)
	{
		Start = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Start);
		End = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.End);
		Blend = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Blend);
		Extrapolation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Extrapolation);
		Influence = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Influence);
		EaseIn = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EaseIn);
		EaseOut = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EaseOut);
		EaseInCurve = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EaseInCurve);
		EaseOutCurve = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EaseOutCurve);
		Muted = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Muted);
		Channels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Channels);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
