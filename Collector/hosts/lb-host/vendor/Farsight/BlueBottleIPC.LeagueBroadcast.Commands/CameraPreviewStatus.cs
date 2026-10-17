using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewStatus")]
public class CameraPreviewStatus : IFlatBufferSerializable<CameraPreviewStatus>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong RequestedGeneration { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong AppliedGeneration { get; set; }

	[FlatBufferItem(2)]
	public virtual CameraPreviewState State { get; set; }

	[FlatBufferItem(3)]
	public virtual CameraPreviewError Error { get; set; }

	[FlatBufferItem(4)]
	public virtual uint ActiveCameraCount { get; set; }

	[FlatBufferItem(5, DefaultValue = 9u)]
	public virtual uint MaximumAuxiliaryCameras { get; set; }

	public static ISerializer<CameraPreviewStatus> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewStatus>)this).Serializer;

	ISerializer<CameraPreviewStatus> IFlatBufferSerializable<CameraPreviewStatus>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002ELazySerializer;

	static ISerializer<CameraPreviewStatus> IFlatBufferSerializable<CameraPreviewStatus>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewStatus> IFlatBufferSerializable<CameraPreviewStatus>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewStatus> IFlatBufferSerializable<CameraPreviewStatus>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewStatus> IFlatBufferSerializable<CameraPreviewStatus>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EProgressiveSerializer;

	static CameraPreviewStatus()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewStatus_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewStatus()
	{
		RequestedGeneration = 0uL;
		AppliedGeneration = 0uL;
		State = CameraPreviewState.Unavailable;
		Error = CameraPreviewError.None;
		ActiveCameraCount = 0u;
		MaximumAuxiliaryCameras = 9u;
	}

	protected CameraPreviewStatus(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewStatus(CameraPreviewStatus source)
	{
		RequestedGeneration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestedGeneration);
		AppliedGeneration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AppliedGeneration);
		State = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.State);
		Error = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Error);
		ActiveCameraCount = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ActiveCameraCount);
		MaximumAuxiliaryCameras = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaximumAuxiliaryCameras);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
