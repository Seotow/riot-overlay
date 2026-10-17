using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSetWorldConstraint")]
public class StrokeSetWorldConstraint : IFlatBufferSerializable<StrokeSetWorldConstraint>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float CenterX { get; set; }

	[FlatBufferItem(1)]
	public virtual float CenterZ { get; set; }

	[FlatBufferItem(2)]
	public virtual float Radius { get; set; }

	public static ISerializer<StrokeSetWorldConstraint> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSetWorldConstraint>)this).Serializer;

	ISerializer<StrokeSetWorldConstraint> IFlatBufferSerializable<StrokeSetWorldConstraint>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSetWorldConstraint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002ELazySerializer;

	static ISerializer<StrokeSetWorldConstraint> IFlatBufferSerializable<StrokeSetWorldConstraint>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSetWorldConstraint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedySerializer;

	static ISerializer<StrokeSetWorldConstraint> IFlatBufferSerializable<StrokeSetWorldConstraint>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSetWorldConstraint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSetWorldConstraint> IFlatBufferSerializable<StrokeSetWorldConstraint>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSetWorldConstraint> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSetWorldConstraint> IFlatBufferSerializable<StrokeSetWorldConstraint>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EProgressiveSerializer;

	static StrokeSetWorldConstraint()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSetWorldConstraint_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSetWorldConstraint()
	{
		CenterX = 0f;
		CenterZ = 0f;
		Radius = 0f;
	}

	protected StrokeSetWorldConstraint(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSetWorldConstraint(StrokeSetWorldConstraint source)
	{
		CenterX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CenterX);
		CenterZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CenterZ);
		Radius = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Radius);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
