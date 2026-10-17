using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetTipStyle")]
public class StrokeSetTipStyle : IFlatBufferSerializable<StrokeSetTipStyle>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual StrokeTipStyle TipStyle { get; set; }

	[FlatBufferItem(1)]
	public virtual bool IsStartTip { get; set; }

	public static ISerializer<StrokeSetTipStyle> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetTipStyle>)this).Serializer;

	ISerializer<StrokeSetTipStyle> IFlatBufferSerializable<StrokeSetTipStyle>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetTipStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002ELazySerializer;

	static ISerializer<StrokeSetTipStyle> IFlatBufferSerializable<StrokeSetTipStyle>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetTipStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedySerializer;

	static ISerializer<StrokeSetTipStyle> IFlatBufferSerializable<StrokeSetTipStyle>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetTipStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetTipStyle> IFlatBufferSerializable<StrokeSetTipStyle>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetTipStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetTipStyle> IFlatBufferSerializable<StrokeSetTipStyle>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EProgressiveSerializer;

	static StrokeSetTipStyle()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetTipStyle_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetTipStyle()
	{
		TipStyle = StrokeTipStyle.circle;
		IsStartTip = false;
	}

	protected StrokeSetTipStyle(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetTipStyle(StrokeSetTipStyle source)
	{
		TipStyle = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TipStyle);
		IsStartTip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsStartTip);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
