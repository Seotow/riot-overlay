using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote")]
public class StrokeSyncPointsRemote : IFlatBufferSerializable<StrokeSyncPointsRemote>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string StrokeId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required IList<Vector3> Points { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<float>? PointGameTimes { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<float>? Pressures { get; set; }

	public static ISerializer<StrokeSyncPointsRemote> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSyncPointsRemote>)this).Serializer;

	ISerializer<StrokeSyncPointsRemote> IFlatBufferSerializable<StrokeSyncPointsRemote>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSyncPointsRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002ELazySerializer;

	static ISerializer<StrokeSyncPointsRemote> IFlatBufferSerializable<StrokeSyncPointsRemote>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSyncPointsRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedySerializer;

	static ISerializer<StrokeSyncPointsRemote> IFlatBufferSerializable<StrokeSyncPointsRemote>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSyncPointsRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSyncPointsRemote> IFlatBufferSerializable<StrokeSyncPointsRemote>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSyncPointsRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSyncPointsRemote> IFlatBufferSerializable<StrokeSyncPointsRemote>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EProgressiveSerializer;

	static StrokeSyncPointsRemote()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncPointsRemote_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSyncPointsRemote()
	{
		PointGameTimes = null;
		Pressures = null;
	}

	protected StrokeSyncPointsRemote(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSyncPointsRemote(StrokeSyncPointsRemote source)
	{
		StrokeId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StrokeId);
		Points = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Points);
		PointGameTimes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PointGameTimes);
		Pressures = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Pressures);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
