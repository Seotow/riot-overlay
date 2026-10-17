using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5963900DD3D9F3D479A787B2C4DE3E20A31CC8CED426DE72F5A27A3FFADF9F80;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOklchColor")]
public class CameraPreviewOklchColor : IFlatBufferSerializable<CameraPreviewOklchColor>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Lightness { get; set; }

	[FlatBufferItem(1)]
	public virtual float Chroma { get; set; }

	[FlatBufferItem(2)]
	public virtual float HueDegrees { get; set; }

	[FlatBufferItem(3, DefaultValue = 1f)]
	public virtual float Alpha { get; set; }

	public static ISerializer<CameraPreviewOklchColor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraPreviewOklchColor>)this).Serializer;

	ISerializer<CameraPreviewOklchColor> IFlatBufferSerializable<CameraPreviewOklchColor>.Serializer => Serializer;

	private static readonly ISerializer<CameraPreviewOklchColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002ELazySerializer;

	static ISerializer<CameraPreviewOklchColor> IFlatBufferSerializable<CameraPreviewOklchColor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002ELazySerializer;

	private static readonly ISerializer<CameraPreviewOklchColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedySerializer;

	static ISerializer<CameraPreviewOklchColor> IFlatBufferSerializable<CameraPreviewOklchColor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraPreviewOklchColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraPreviewOklchColor> IFlatBufferSerializable<CameraPreviewOklchColor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraPreviewOklchColor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EProgressiveSerializer;

	static ISerializer<CameraPreviewOklchColor> IFlatBufferSerializable<CameraPreviewOklchColor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EProgressiveSerializer;

	static CameraPreviewOklchColor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ECameraPreviewOklchColor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraPreviewOklchColor()
	{
		Lightness = 0f;
		Chroma = 0f;
		HueDegrees = 0f;
		Alpha = 1f;
	}

	protected CameraPreviewOklchColor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraPreviewOklchColor(CameraPreviewOklchColor source)
	{
		Lightness = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Lightness);
		Chroma = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Chroma);
		HueDegrees = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.HueDegrees);
		Alpha = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Alpha);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
