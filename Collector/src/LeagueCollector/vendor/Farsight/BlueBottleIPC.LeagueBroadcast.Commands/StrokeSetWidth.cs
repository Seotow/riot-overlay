using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetWidth")]
public class StrokeSetWidth : IFlatBufferSerializable<StrokeSetWidth>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Width { get; set; }

	public static ISerializer<StrokeSetWidth> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetWidth>)this).Serializer;

	ISerializer<StrokeSetWidth> IFlatBufferSerializable<StrokeSetWidth>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002ELazySerializer;

	static ISerializer<StrokeSetWidth> IFlatBufferSerializable<StrokeSetWidth>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedySerializer;

	static ISerializer<StrokeSetWidth> IFlatBufferSerializable<StrokeSetWidth>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetWidth> IFlatBufferSerializable<StrokeSetWidth>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetWidth> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetWidth> IFlatBufferSerializable<StrokeSetWidth>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EProgressiveSerializer;

	static StrokeSetWidth()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWidth_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetWidth()
	{
		Width = 0f;
	}

	protected StrokeSetWidth(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetWidth(StrokeSetWidth source)
	{
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
