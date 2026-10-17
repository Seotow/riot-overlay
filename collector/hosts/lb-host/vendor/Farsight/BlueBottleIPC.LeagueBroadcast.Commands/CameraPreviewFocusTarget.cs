using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NDC9343510231A2B29756F60BC088D1CACA8CA01435E2703E99F5D3BA16DD5A67;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewFocusTarget")]
public class CameraPreviewFocusTarget : IFlatBufferSerializable<CameraPreviewFocusTarget>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual CameraPreviewFocusTargetKind Kind { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(2)]
	public virtual Vector3? Point { get; set; }

	public static ISerializer<CameraPreviewFocusTarget> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewFocusTarget>)this).Serializer;

	ISerializer<CameraPreviewFocusTarget> IFlatBufferSerializable<CameraPreviewFocusTarget>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewFocusTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002ELazySerializer;

	static ISerializer<CameraPreviewFocusTarget> IFlatBufferSerializable<CameraPreviewFocusTarget>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewFocusTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewFocusTarget> IFlatBufferSerializable<CameraPreviewFocusTarget>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewFocusTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewFocusTarget> IFlatBufferSerializable<CameraPreviewFocusTarget>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewFocusTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewFocusTarget> IFlatBufferSerializable<CameraPreviewFocusTarget>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EProgressiveSerializer;

	static CameraPreviewFocusTarget()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewFocusTarget_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewFocusTarget()
	{
		Kind = CameraPreviewFocusTargetKind.NetworkId;
		Id = 0u;
		Point = null;
	}

	protected CameraPreviewFocusTarget(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewFocusTarget(CameraPreviewFocusTarget source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Point = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Point);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
