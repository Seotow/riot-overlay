using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE31186FB17ED2893C1E8419BB85615FB034D91FEB0BE08A2F34AB859FF149799;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.CameraLookAtSettings")]
public class CameraLookAtSettings : IFlatBufferSerializable<CameraLookAtSettings>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual CameraLookAtSource Source { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Binding { get; set; }

	[FlatBufferItem(2)]
	public virtual uint NetworkId { get; set; }

	[FlatBufferItem(3)]
	public virtual CameraLookAtTeam Team { get; set; }

	[FlatBufferItem(4, DefaultValue = 1)]
	public virtual byte TeamPosition { get; set; }

	[FlatBufferItem(5)]
	public virtual CameraLookAtObjective Objective { get; set; }

	[FlatBufferItem(6)]
	public virtual float OffsetX { get; set; }

	[FlatBufferItem(7)]
	public virtual float OffsetY { get; set; }

	[FlatBufferItem(8)]
	public virtual float OffsetZ { get; set; }

	public static ISerializer<CameraLookAtSettings> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraLookAtSettings>)this).Serializer;

	ISerializer<CameraLookAtSettings> IFlatBufferSerializable<CameraLookAtSettings>.Serializer => Serializer;

	private static readonly ISerializer<CameraLookAtSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002ELazySerializer;

	static ISerializer<CameraLookAtSettings> IFlatBufferSerializable<CameraLookAtSettings>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002ELazySerializer;

	private static readonly ISerializer<CameraLookAtSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedySerializer;

	static ISerializer<CameraLookAtSettings> IFlatBufferSerializable<CameraLookAtSettings>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraLookAtSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraLookAtSettings> IFlatBufferSerializable<CameraLookAtSettings>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraLookAtSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EProgressiveSerializer;

	static ISerializer<CameraLookAtSettings> IFlatBufferSerializable<CameraLookAtSettings>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EProgressiveSerializer;

	static CameraLookAtSettings()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002ECameraLookAtSettings_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraLookAtSettings()
	{
		Source = CameraLookAtSource.None;
		Binding = 0u;
		NetworkId = 0u;
		Team = CameraLookAtTeam.Blue;
		TeamPosition = 1;
		Objective = CameraLookAtObjective.Grubs;
		OffsetX = 0f;
		OffsetY = 0f;
		OffsetZ = 0f;
	}

	protected CameraLookAtSettings(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraLookAtSettings(CameraLookAtSettings source)
	{
		Source = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Source);
		Binding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Binding);
		NetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NetworkId);
		Team = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Team);
		TeamPosition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TeamPosition);
		Objective = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Objective);
		OffsetX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetX);
		OffsetY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetY);
		OffsetZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OffsetZ);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
