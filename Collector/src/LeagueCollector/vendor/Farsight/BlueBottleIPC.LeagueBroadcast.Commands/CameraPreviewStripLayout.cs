using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewStripLayout")]
public class CameraPreviewStripLayout : IFlatBufferSerializable<CameraPreviewStripLayout>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<CameraPreviewCameraSource>? Panes { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<float>? Weights { get; set; }

	[FlatBufferItem(2, DefaultValue = 56f)]
	public virtual float SlantPixels { get; set; }

	public static ISerializer<CameraPreviewStripLayout> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewStripLayout>)this).Serializer;

	ISerializer<CameraPreviewStripLayout> IFlatBufferSerializable<CameraPreviewStripLayout>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewStripLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002ELazySerializer;

	static ISerializer<CameraPreviewStripLayout> IFlatBufferSerializable<CameraPreviewStripLayout>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewStripLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewStripLayout> IFlatBufferSerializable<CameraPreviewStripLayout>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewStripLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewStripLayout> IFlatBufferSerializable<CameraPreviewStripLayout>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewStripLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewStripLayout> IFlatBufferSerializable<CameraPreviewStripLayout>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EProgressiveSerializer;

	static CameraPreviewStripLayout()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStripLayout_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewStripLayout()
	{
		Panes = null;
		Weights = null;
		SlantPixels = 56f;
	}

	protected CameraPreviewStripLayout(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewStripLayout(CameraPreviewStripLayout source)
	{
		Panes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Panes);
		Weights = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Weights);
		SlantPixels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SlantPixels);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
