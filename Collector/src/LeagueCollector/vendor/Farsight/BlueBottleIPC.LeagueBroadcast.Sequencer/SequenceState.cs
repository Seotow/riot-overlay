using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF498DAD23117C3EE4094D7C217F705E1F5342DD4A91E922B1A6BE9C43B410260;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState")]
public class SequenceState : IFlatBufferSerializable<SequenceState>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? SequenceId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<SequenceClipState>? Clips { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<uint>? BrokenBindings { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<string>? FiredMarkers { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<SeqProperty>? DrivableProperties { get; set; }

	[FlatBufferItem(5)]
	public virtual CameraHold Camera { get; set; }

	public static ISerializer<SequenceState> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SequenceState>)this).Serializer;

	ISerializer<SequenceState> IFlatBufferSerializable<SequenceState>.Serializer => Serializer;

	private static readonly ISerializer<SequenceState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002ELazySerializer;

	static ISerializer<SequenceState> IFlatBufferSerializable<SequenceState>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002ELazySerializer;

	private static readonly ISerializer<SequenceState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedySerializer;

	static ISerializer<SequenceState> IFlatBufferSerializable<SequenceState>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedySerializer;

	private static readonly ISerializer<SequenceState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedyMutableSerializer;

	static ISerializer<SequenceState> IFlatBufferSerializable<SequenceState>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SequenceState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EProgressiveSerializer;

	static ISerializer<SequenceState> IFlatBufferSerializable<SequenceState>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EProgressiveSerializer;

	static SequenceState()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ESequenceState_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SequenceState()
	{
		SequenceId = null;
		Clips = null;
		BrokenBindings = null;
		FiredMarkers = null;
		DrivableProperties = null;
		Camera = CameraHold.Idle;
	}

	protected SequenceState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SequenceState(SequenceState source)
	{
		SequenceId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SequenceId);
		Clips = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Clips);
		BrokenBindings = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BrokenBindings);
		FiredMarkers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FiredMarkers);
		DrivableProperties = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DrivableProperties);
		Camera = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Camera);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
