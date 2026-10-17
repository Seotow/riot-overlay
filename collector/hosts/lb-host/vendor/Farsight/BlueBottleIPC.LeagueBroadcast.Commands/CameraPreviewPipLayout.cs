using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewPipLayout")]
public class CameraPreviewPipLayout : IFlatBufferSerializable<CameraPreviewPipLayout>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required CameraPreviewCameraSource Source { get; set; }

	[FlatBufferItem(1, DefaultValue = 0.7f)]
	public virtual float X { get; set; }

	[FlatBufferItem(2, DefaultValue = 0.05f)]
	public virtual float Y { get; set; }

	[FlatBufferItem(3, DefaultValue = 0.25f)]
	public virtual float Width { get; set; }

	[FlatBufferItem(4, DefaultValue = 0.25f)]
	public virtual float Height { get; set; }

	[FlatBufferItem(5)]
	public virtual bool ScaleHealthBarsToPip { get; set; }

	public static ISerializer<CameraPreviewPipLayout> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewPipLayout>)this).Serializer;

	ISerializer<CameraPreviewPipLayout> IFlatBufferSerializable<CameraPreviewPipLayout>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewPipLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002ELazySerializer;

	static ISerializer<CameraPreviewPipLayout> IFlatBufferSerializable<CameraPreviewPipLayout>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewPipLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewPipLayout> IFlatBufferSerializable<CameraPreviewPipLayout>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewPipLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewPipLayout> IFlatBufferSerializable<CameraPreviewPipLayout>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewPipLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewPipLayout> IFlatBufferSerializable<CameraPreviewPipLayout>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EProgressiveSerializer;

	static CameraPreviewPipLayout()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewPipLayout_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewPipLayout()
	{
		X = 0.7f;
		Y = 0.05f;
		Width = 0.25f;
		Height = 0.25f;
		ScaleHealthBarsToPip = false;
	}

	protected CameraPreviewPipLayout(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewPipLayout(CameraPreviewPipLayout source)
	{
		Source = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Source);
		X = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.X);
		Y = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Y);
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
		Height = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Height);
		ScaleHealthBarsToPip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScaleHealthBarsToPip);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
