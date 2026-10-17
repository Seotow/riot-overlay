using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1FA056D5DB287BB0CE58AA570D08AB14A6CD5484918CE0C3810B407FDD18869A;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController")]
public class CameraPreviewDirectorController : IFlatBufferSerializable<CameraPreviewDirectorController>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<CameraPreviewDirectorTarget>? Targets { get; set; }

	[FlatBufferItem(1, DefaultValue = 450f)]
	public virtual float Padding { get; set; }

	[FlatBufferItem(2, DefaultValue = 1600f)]
	public virtual float MinimumDistance { get; set; }

	[FlatBufferItem(3, DefaultValue = 15000f)]
	public virtual float MaximumDistance { get; set; }

	[FlatBufferItem(4)]
	public virtual float TargetHeight { get; set; }

	[FlatBufferItem(5, DefaultValue = true)]
	public virtual bool OverrideTargetHeight { get; set; }

	[FlatBufferItem(6)]
	public virtual float VerticalFovDegrees { get; set; }

	[FlatBufferItem(7, DefaultValue = 0.54f)]
	public virtual float DeadZoneWidth { get; set; }

	[FlatBufferItem(8, DefaultValue = 0.48f)]
	public virtual float DeadZoneHeight { get; set; }

	[FlatBufferItem(9, DefaultValue = 0.78f)]
	public virtual float SoftZoneWidth { get; set; }

	[FlatBufferItem(10, DefaultValue = 0.72f)]
	public virtual float SoftZoneHeight { get; set; }

	[FlatBufferItem(11, DefaultValue = 0.93f)]
	public virtual float HardZoneWidth { get; set; }

	[FlatBufferItem(12, DefaultValue = 0.88f)]
	public virtual float HardZoneHeight { get; set; }

	[FlatBufferItem(13, DefaultValue = 0.35f)]
	public virtual float SoftZoneDwellSeconds { get; set; }

	[FlatBufferItem(14, DefaultValue = 0.18f)]
	public virtual float TargetAdmissionSeconds { get; set; }

	[FlatBufferItem(15, DefaultValue = 0.65f)]
	public virtual float MinimumReframeDurationSeconds { get; set; }

	[FlatBufferItem(16, DefaultValue = 1.8f)]
	public virtual float MaximumReframeDurationSeconds { get; set; }

	[FlatBufferItem(17, DefaultValue = 1.75f)]
	public virtual float CutThresholdViewports { get; set; }

	[FlatBufferItem(18, DefaultValue = true)]
	public virtual bool AllowCuts { get; set; }

	[FlatBufferItem(19, DefaultValue = 6f)]
	public virtual float ZoomInDelaySeconds { get; set; }

	[FlatBufferItem(20, DefaultValue = 1.18f)]
	public virtual float ZoomInStepRatio { get; set; }

	[FlatBufferItem(21)]
	public virtual float Urgency { get; set; }

	[FlatBufferItem(22, DefaultValue = 7000f)]
	public virtual float LocalStoryMaximumDistance { get; set; }

	[FlatBufferItem(23, DefaultValue = 0.6f)]
	public virtual float LocalStorySwitchSeconds { get; set; }

	[FlatBufferItem(24, DefaultValue = 2500f)]
	public virtual float LocalEngagementRadius { get; set; }

	[FlatBufferItem(25, DefaultValue = 0.12f)]
	public virtual float ActiveReplanSeconds { get; set; }

	[FlatBufferItem(26, DefaultValue = 0.68f)]
	public virtual float CompositionZoneWidth { get; set; }

	[FlatBufferItem(27, DefaultValue = 0.62f)]
	public virtual float CompositionZoneHeight { get; set; }

	[FlatBufferItem(28)]
	public virtual CameraPreviewProjectileFollowMode ProjectileFollowMode { get; set; }

	public static ISerializer<CameraPreviewDirectorController> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewDirectorController>)this).Serializer;

	ISerializer<CameraPreviewDirectorController> IFlatBufferSerializable<CameraPreviewDirectorController>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewDirectorController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002ELazySerializer;

	static ISerializer<CameraPreviewDirectorController> IFlatBufferSerializable<CameraPreviewDirectorController>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewDirectorController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewDirectorController> IFlatBufferSerializable<CameraPreviewDirectorController>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewDirectorController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewDirectorController> IFlatBufferSerializable<CameraPreviewDirectorController>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewDirectorController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewDirectorController> IFlatBufferSerializable<CameraPreviewDirectorController>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EProgressiveSerializer;

	static CameraPreviewDirectorController()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorController_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewDirectorController()
	{
		Targets = null;
		Padding = 450f;
		MinimumDistance = 1600f;
		MaximumDistance = 15000f;
		TargetHeight = 0f;
		OverrideTargetHeight = true;
		VerticalFovDegrees = 0f;
		DeadZoneWidth = 0.54f;
		DeadZoneHeight = 0.48f;
		SoftZoneWidth = 0.78f;
		SoftZoneHeight = 0.72f;
		HardZoneWidth = 0.93f;
		HardZoneHeight = 0.88f;
		SoftZoneDwellSeconds = 0.35f;
		TargetAdmissionSeconds = 0.18f;
		MinimumReframeDurationSeconds = 0.65f;
		MaximumReframeDurationSeconds = 1.8f;
		CutThresholdViewports = 1.75f;
		AllowCuts = true;
		ZoomInDelaySeconds = 6f;
		ZoomInStepRatio = 1.18f;
		Urgency = 0f;
		LocalStoryMaximumDistance = 7000f;
		LocalStorySwitchSeconds = 0.6f;
		LocalEngagementRadius = 2500f;
		ActiveReplanSeconds = 0.12f;
		CompositionZoneWidth = 0.68f;
		CompositionZoneHeight = 0.62f;
		ProjectileFollowMode = CameraPreviewProjectileFollowMode.Off;
	}

	protected CameraPreviewDirectorController(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewDirectorController(CameraPreviewDirectorController source)
	{
		Targets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Targets);
		Padding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Padding);
		MinimumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimumDistance);
		MaximumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaximumDistance);
		TargetHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetHeight);
		OverrideTargetHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OverrideTargetHeight);
		VerticalFovDegrees = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VerticalFovDegrees);
		DeadZoneWidth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DeadZoneWidth);
		DeadZoneHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DeadZoneHeight);
		SoftZoneWidth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SoftZoneWidth);
		SoftZoneHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SoftZoneHeight);
		HardZoneWidth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HardZoneWidth);
		HardZoneHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HardZoneHeight);
		SoftZoneDwellSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SoftZoneDwellSeconds);
		TargetAdmissionSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetAdmissionSeconds);
		MinimumReframeDurationSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimumReframeDurationSeconds);
		MaximumReframeDurationSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaximumReframeDurationSeconds);
		CutThresholdViewports = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CutThresholdViewports);
		AllowCuts = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AllowCuts);
		ZoomInDelaySeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZoomInDelaySeconds);
		ZoomInStepRatio = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZoomInStepRatio);
		Urgency = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Urgency);
		LocalStoryMaximumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LocalStoryMaximumDistance);
		LocalStorySwitchSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LocalStorySwitchSeconds);
		LocalEngagementRadius = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LocalEngagementRadius);
		ActiveReplanSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ActiveReplanSeconds);
		CompositionZoneWidth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CompositionZoneWidth);
		CompositionZoneHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CompositionZoneHeight);
		ProjectileFollowMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ProjectileFollowMode);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
