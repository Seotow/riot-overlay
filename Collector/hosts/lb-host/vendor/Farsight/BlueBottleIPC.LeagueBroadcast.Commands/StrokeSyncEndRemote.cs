using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncEndRemote")]
public class StrokeSyncEndRemote : IFlatBufferSerializable<StrokeSyncEndRemote>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string StrokeId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<Vector3>? FinalPoints { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<float>? PointGameTimes { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<float>? Pressures { get; set; }

	public static ISerializer<StrokeSyncEndRemote> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StrokeSyncEndRemote>)this).Serializer;

	ISerializer<StrokeSyncEndRemote> IFlatBufferSerializable<StrokeSyncEndRemote>.Serializer => Serializer;

	private static readonly ISerializer<StrokeSyncEndRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002ELazySerializer;

	static ISerializer<StrokeSyncEndRemote> IFlatBufferSerializable<StrokeSyncEndRemote>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002ELazySerializer;

	private static readonly ISerializer<StrokeSyncEndRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedySerializer;

	static ISerializer<StrokeSyncEndRemote> IFlatBufferSerializable<StrokeSyncEndRemote>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedySerializer;

	private static readonly ISerializer<StrokeSyncEndRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedyMutableSerializer;

	static ISerializer<StrokeSyncEndRemote> IFlatBufferSerializable<StrokeSyncEndRemote>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StrokeSyncEndRemote> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EProgressiveSerializer;

	static ISerializer<StrokeSyncEndRemote> IFlatBufferSerializable<StrokeSyncEndRemote>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EProgressiveSerializer;

	static StrokeSyncEndRemote()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStrokeSyncEndRemote_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StrokeSyncEndRemote()
	{
		FinalPoints = null;
		PointGameTimes = null;
		Pressures = null;
	}

	protected StrokeSyncEndRemote(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSyncEndRemote(StrokeSyncEndRemote source)
	{
		StrokeId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StrokeId);
		FinalPoints = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FinalPoints);
		PointGameTimes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PointGameTimes);
		Pressures = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Pressures);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
