using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition")]
public class CameraPreviewOutputDefinition : IFlatBufferSerializable<CameraPreviewOutputDefinition>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Id { get; set; }

	[FlatBufferItem(1)]
	public virtual CameraPreviewOutputDestination Destination { get; set; }

	[FlatBufferItem(2)]
	public virtual CameraPreviewLayout? Layout { get; set; }

	[FlatBufferItem(4)]
	public virtual CameraPreviewBorderStyle? Border { get; set; }

	[FlatBufferItem(5)]
	public virtual CameraPreviewTransition? Transition { get; set; }

	public static ISerializer<CameraPreviewOutputDefinition> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewOutputDefinition>)this).Serializer;

	ISerializer<CameraPreviewOutputDefinition> IFlatBufferSerializable<CameraPreviewOutputDefinition>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewOutputDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002ELazySerializer;

	static ISerializer<CameraPreviewOutputDefinition> IFlatBufferSerializable<CameraPreviewOutputDefinition>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewOutputDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewOutputDefinition> IFlatBufferSerializable<CameraPreviewOutputDefinition>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewOutputDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewOutputDefinition> IFlatBufferSerializable<CameraPreviewOutputDefinition>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewOutputDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewOutputDefinition> IFlatBufferSerializable<CameraPreviewOutputDefinition>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EProgressiveSerializer;

	static CameraPreviewOutputDefinition()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOutputDefinition_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewOutputDefinition()
	{
		Destination = CameraPreviewOutputDestination.InGame;
		Layout = null;
		Border = null;
		Transition = null;
	}

	protected CameraPreviewOutputDefinition(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewOutputDefinition(CameraPreviewOutputDefinition source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Destination = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Destination);
		Layout = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Layout);
		Border = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Border);
		Transition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Transition);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
