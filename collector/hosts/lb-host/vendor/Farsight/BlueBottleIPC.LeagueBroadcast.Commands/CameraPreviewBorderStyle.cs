using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewBorderStyle")]
public class CameraPreviewBorderStyle : IFlatBufferSerializable<CameraPreviewBorderStyle>, IFlatBufferSerializable
{
	[FlatBufferItem(0, DefaultValue = 6f)]
	public virtual float WidthPixels { get; set; }

	[FlatBufferItem(1, DefaultValue = 90f)]
	public virtual float GradientAngleDegrees { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<CameraPreviewGradientStop>? Stops { get; set; }

	[FlatBufferItem(3)]
	public virtual float WidthReferenceHeightPixels { get; set; }

	[FlatBufferItem(4)]
	public virtual CameraPreviewGradientAnimationKind AnimationKind { get; set; }

	[FlatBufferItem(5, DefaultValue = 4f)]
	public virtual float AnimationCycleSeconds { get; set; }

	[FlatBufferItem(6)]
	public virtual bool AnimationReverse { get; set; }

	public static ISerializer<CameraPreviewBorderStyle> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewBorderStyle>)this).Serializer;

	ISerializer<CameraPreviewBorderStyle> IFlatBufferSerializable<CameraPreviewBorderStyle>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewBorderStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002ELazySerializer;

	static ISerializer<CameraPreviewBorderStyle> IFlatBufferSerializable<CameraPreviewBorderStyle>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewBorderStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewBorderStyle> IFlatBufferSerializable<CameraPreviewBorderStyle>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewBorderStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewBorderStyle> IFlatBufferSerializable<CameraPreviewBorderStyle>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewBorderStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewBorderStyle> IFlatBufferSerializable<CameraPreviewBorderStyle>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EProgressiveSerializer;

	static CameraPreviewBorderStyle()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewBorderStyle_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewBorderStyle()
	{
		WidthPixels = 6f;
		GradientAngleDegrees = 90f;
		Stops = null;
		WidthReferenceHeightPixels = 0f;
		AnimationKind = CameraPreviewGradientAnimationKind.None;
		AnimationCycleSeconds = 4f;
		AnimationReverse = false;
	}

	protected CameraPreviewBorderStyle(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewBorderStyle(CameraPreviewBorderStyle source)
	{
		WidthPixels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.WidthPixels);
		GradientAngleDegrees = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GradientAngleDegrees);
		Stops = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Stops);
		WidthReferenceHeightPixels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.WidthReferenceHeightPixels);
		AnimationKind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationKind);
		AnimationCycleSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationCycleSeconds);
		AnimationReverse = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationReverse);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
