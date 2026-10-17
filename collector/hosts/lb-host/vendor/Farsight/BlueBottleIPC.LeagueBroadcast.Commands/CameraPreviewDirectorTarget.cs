using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC5ED364154C495EC121D4C459B45500CDEA8C30152693D7AB19A697367DB3A52;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorTarget")]
public class CameraPreviewDirectorTarget : IFlatBufferSerializable<CameraPreviewDirectorTarget>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual CameraPreviewFocusTargetKind Kind { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(2)]
	public virtual Vector3? Point { get; set; }

	[FlatBufferItem(3)]
	public virtual CameraPreviewDirectorTargetRole Role { get; set; }

	[FlatBufferItem(4)]
	public virtual float Padding { get; set; }

	public static ISerializer<CameraPreviewDirectorTarget> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewDirectorTarget>)this).Serializer;

	ISerializer<CameraPreviewDirectorTarget> IFlatBufferSerializable<CameraPreviewDirectorTarget>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewDirectorTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002ELazySerializer;

	static ISerializer<CameraPreviewDirectorTarget> IFlatBufferSerializable<CameraPreviewDirectorTarget>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewDirectorTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewDirectorTarget> IFlatBufferSerializable<CameraPreviewDirectorTarget>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewDirectorTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewDirectorTarget> IFlatBufferSerializable<CameraPreviewDirectorTarget>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewDirectorTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewDirectorTarget> IFlatBufferSerializable<CameraPreviewDirectorTarget>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EProgressiveSerializer;

	static CameraPreviewDirectorTarget()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewDirectorTarget_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewDirectorTarget()
	{
		Kind = CameraPreviewFocusTargetKind.NetworkId;
		Id = 0u;
		Point = null;
		Role = CameraPreviewDirectorTargetRole.Required;
		Padding = 0f;
	}

	protected CameraPreviewDirectorTarget(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewDirectorTarget(CameraPreviewDirectorTarget source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Point = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Point);
		Role = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Role);
		Padding = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Padding);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
