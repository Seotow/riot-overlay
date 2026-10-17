using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N50369821530AF660841175CE0251C31EA5CA9998230B9375C91B083F021933A6;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewConfiguration")]
public class CameraPreviewConfiguration : IFlatBufferSerializable<CameraPreviewConfiguration>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong Generation { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<CameraPreviewCameraDefinition>? Cameras { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<CameraPreviewOutputDefinition>? Outputs { get; set; }

	public static ISerializer<CameraPreviewConfiguration> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewConfiguration>)this).Serializer;

	ISerializer<CameraPreviewConfiguration> IFlatBufferSerializable<CameraPreviewConfiguration>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewConfiguration> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002ELazySerializer;

	static ISerializer<CameraPreviewConfiguration> IFlatBufferSerializable<CameraPreviewConfiguration>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewConfiguration> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewConfiguration> IFlatBufferSerializable<CameraPreviewConfiguration>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewConfiguration> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewConfiguration> IFlatBufferSerializable<CameraPreviewConfiguration>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewConfiguration> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewConfiguration> IFlatBufferSerializable<CameraPreviewConfiguration>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EProgressiveSerializer;

	static CameraPreviewConfiguration()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewConfiguration_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewConfiguration()
	{
		Generation = 0uL;
		Cameras = null;
		Outputs = null;
	}

	protected CameraPreviewConfiguration(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewConfiguration(CameraPreviewConfiguration source)
	{
		Generation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Generation);
		Cameras = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Cameras);
		Outputs = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Outputs);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
