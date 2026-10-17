using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewFocusTargetsController")]
public class CameraPreviewFocusTargetsController : IFlatBufferSerializable<CameraPreviewFocusTargetsController>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<CameraPreviewFocusTarget>? Targets { get; set; }

	[FlatBufferItem(1, DefaultValue = 450f)]
	public virtual float Padding { get; set; }

	[FlatBufferItem(2, DefaultValue = 0.82f)]
	public virtual float FrameCoverage { get; set; }

	[FlatBufferItem(3, DefaultValue = 1600f)]
	public virtual float MinimumDistance { get; set; }

	[FlatBufferItem(4, DefaultValue = 15000f)]
	public virtual float MaximumDistance { get; set; }

	[FlatBufferItem(5)]
	public virtual float TargetHeight { get; set; }

	[FlatBufferItem(6, DefaultValue = true)]
	public virtual bool OverrideTargetHeight { get; set; }

	[FlatBufferItem(7)]
	public virtual float VerticalFovDegrees { get; set; }

	[FlatBufferItem(8)]
	public virtual bool CompactGroupFraming { get; set; }

	[FlatBufferItem(9, DefaultValue = 6000f)]
	public virtual float CompactGroupMaximumDistance { get; set; }

	[FlatBufferItem(10, DefaultValue = 12f)]
	public virtual float MovementStiffness { get; set; }

	[FlatBufferItem(11, DefaultValue = 3f)]
	public virtual float FramingZoomOutStiffness { get; set; }

	[FlatBufferItem(12, DefaultValue = 1.2f)]
	public virtual float FramingZoomInStiffness { get; set; }

	[FlatBufferItem(13, DefaultValue = 0.1f)]
	public virtual float FramingDeadbandFraction { get; set; }

	[FlatBufferItem(14, DefaultValue = 1500f)]
	public virtual float JumpRadius { get; set; }

	[FlatBufferItem(15)]
	public virtual CameraPreviewFocusJumpMode JumpMode { get; set; }

	[FlatBufferItem(16, DefaultValue = 0.6f)]
	public virtual float JumpLeadDurationSeconds { get; set; }

	[FlatBufferItem(17, DefaultValue = 1000f)]
	public virtual float JumpLeadDistance { get; set; }

	[FlatBufferItem(18, DefaultValue = 0.55f)]
	public virtual float JumpLeadOutDurationSeconds { get; set; }

	public static ISerializer<CameraPreviewFocusTargetsController> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewFocusTargetsController>)this).Serializer;

	ISerializer<CameraPreviewFocusTargetsController> IFlatBufferSerializable<CameraPreviewFocusTargetsController>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewFocusTargetsController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002ELazySerializer;

	static ISerializer<CameraPreviewFocusTargetsController> IFlatBufferSerializable<CameraPreviewFocusTargetsController>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewFocusTargetsController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewFocusTargetsController> IFlatBufferSerializable<CameraPreviewFocusTargetsController>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewFocusTargetsController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewFocusTargetsController> IFlatBufferSerializable<CameraPreviewFocusTargetsController>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewFocusTargetsController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewFocusTargetsController> IFlatBufferSerializable<CameraPreviewFocusTargetsController>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EProgressiveSerializer;

	static CameraPreviewFocusTargetsController()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTargetsController_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewFocusTargetsController()
	{
		Targets = null;
		Padding = 450f;
		FrameCoverage = 0.82f;
		MinimumDistance = 1600f;
		MaximumDistance = 15000f;
		TargetHeight = 0f;
		OverrideTargetHeight = true;
		VerticalFovDegrees = 0f;
		CompactGroupFraming = false;
		CompactGroupMaximumDistance = 6000f;
		MovementStiffness = 12f;
		FramingZoomOutStiffness = 3f;
		FramingZoomInStiffness = 1.2f;
		FramingDeadbandFraction = 0.1f;
		JumpRadius = 1500f;
		JumpMode = CameraPreviewFocusJumpMode.Cut;
		JumpLeadDurationSeconds = 0.6f;
		JumpLeadDistance = 1000f;
		JumpLeadOutDurationSeconds = 0.55f;
	}

	protected CameraPreviewFocusTargetsController(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewFocusTargetsController(CameraPreviewFocusTargetsController source)
	{
		Targets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Targets);
		Padding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Padding);
		FrameCoverage = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FrameCoverage);
		MinimumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimumDistance);
		MaximumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaximumDistance);
		TargetHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetHeight);
		OverrideTargetHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OverrideTargetHeight);
		VerticalFovDegrees = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VerticalFovDegrees);
		CompactGroupFraming = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CompactGroupFraming);
		CompactGroupMaximumDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CompactGroupMaximumDistance);
		MovementStiffness = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MovementStiffness);
		FramingZoomOutStiffness = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FramingZoomOutStiffness);
		FramingZoomInStiffness = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FramingZoomInStiffness);
		FramingDeadbandFraction = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FramingDeadbandFraction);
		JumpRadius = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpRadius);
		JumpMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpMode);
		JumpLeadDurationSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpLeadDurationSeconds);
		JumpLeadDistance = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpLeadDistance);
		JumpLeadOutDurationSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpLeadOutDurationSeconds);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
