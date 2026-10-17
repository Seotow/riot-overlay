using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N3D5044886A1EF73DDF18C88AECC1478E5E465DFDC8ED64D8DA0A770EB93FEDBB;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.TakeCameraPreviewAux")]
public class TakeCameraPreviewAux : IFlatBufferSerializable<TakeCameraPreviewAux>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string OutputId { get; set; }

	[FlatBufferItem(2, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string CameraId { get; set; }

	public static ISerializer<TakeCameraPreviewAux> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<TakeCameraPreviewAux>)this).Serializer;

	ISerializer<TakeCameraPreviewAux> IFlatBufferSerializable<TakeCameraPreviewAux>.Serializer => Serializer;

	private static readonly ISerializer<TakeCameraPreviewAux> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002ELazySerializer;

	static ISerializer<TakeCameraPreviewAux> IFlatBufferSerializable<TakeCameraPreviewAux>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002ELazySerializer;

	private static readonly ISerializer<TakeCameraPreviewAux> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedySerializer;

	static ISerializer<TakeCameraPreviewAux> IFlatBufferSerializable<TakeCameraPreviewAux>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedySerializer;

	private static readonly ISerializer<TakeCameraPreviewAux> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedyMutableSerializer;

	static ISerializer<TakeCameraPreviewAux> IFlatBufferSerializable<TakeCameraPreviewAux>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<TakeCameraPreviewAux> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EProgressiveSerializer;

	static ISerializer<TakeCameraPreviewAux> IFlatBufferSerializable<TakeCameraPreviewAux>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EProgressiveSerializer;

	static TakeCameraPreviewAux()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETakeCameraPreviewAux_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public TakeCameraPreviewAux()
	{
		Generation = 0uL;
	}

	protected TakeCameraPreviewAux(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public TakeCameraPreviewAux(TakeCameraPreviewAux source)
	{
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		OutputId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OutputId);
		CameraId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CameraId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
