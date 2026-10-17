using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewFixedPoseController")]
public class CameraPreviewFixedPoseController : IFlatBufferSerializable<CameraPreviewFixedPoseController>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Eye { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Target { get; set; }

	[FlatBufferItem(2, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Up { get; set; }

	[FlatBufferItem(3)]
	public virtual float VerticalFovDegrees { get; set; }

	public static ISerializer<CameraPreviewFixedPoseController> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewFixedPoseController>)this).Serializer;

	ISerializer<CameraPreviewFixedPoseController> IFlatBufferSerializable<CameraPreviewFixedPoseController>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewFixedPoseController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002ELazySerializer;

	static ISerializer<CameraPreviewFixedPoseController> IFlatBufferSerializable<CameraPreviewFixedPoseController>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewFixedPoseController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewFixedPoseController> IFlatBufferSerializable<CameraPreviewFixedPoseController>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewFixedPoseController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewFixedPoseController> IFlatBufferSerializable<CameraPreviewFixedPoseController>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewFixedPoseController> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewFixedPoseController> IFlatBufferSerializable<CameraPreviewFixedPoseController>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EProgressiveSerializer;

	static CameraPreviewFixedPoseController()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFixedPoseController_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewFixedPoseController()
	{
		VerticalFovDegrees = 0f;
	}

	protected CameraPreviewFixedPoseController(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewFixedPoseController(CameraPreviewFixedPoseController source)
	{
		Eye = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Eye);
		Target = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Target);
		Up = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Up);
		VerticalFovDegrees = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VerticalFovDegrees);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
