using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureStatus")]
public class StreamTextureStatus : IFlatBufferSerializable<StreamTextureStatus>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual StreamTextureState State { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Codec { get; set; }

	[FlatBufferItem(2)]
	public virtual uint Width { get; set; }

	[FlatBufferItem(3)]
	public virtual uint Height { get; set; }

	[FlatBufferItem(4)]
	public virtual ulong LastFrameUnixMs { get; set; }

	[FlatBufferItem(5)]
	public virtual string? Error { get; set; }

	public static ISerializer<StreamTextureStatus> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<StreamTextureStatus>)this).Serializer;

	ISerializer<StreamTextureStatus> IFlatBufferSerializable<StreamTextureStatus>.Serializer => Serializer;

	private static readonly ISerializer<StreamTextureStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002ELazySerializer;

	static ISerializer<StreamTextureStatus> IFlatBufferSerializable<StreamTextureStatus>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002ELazySerializer;

	private static readonly ISerializer<StreamTextureStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedySerializer;

	static ISerializer<StreamTextureStatus> IFlatBufferSerializable<StreamTextureStatus>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedySerializer;

	private static readonly ISerializer<StreamTextureStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedyMutableSerializer;

	static ISerializer<StreamTextureStatus> IFlatBufferSerializable<StreamTextureStatus>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<StreamTextureStatus> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EProgressiveSerializer;

	static ISerializer<StreamTextureStatus> IFlatBufferSerializable<StreamTextureStatus>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EProgressiveSerializer;

	static StreamTextureStatus()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EStreamTextureStatus_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public StreamTextureStatus()
	{
		State = StreamTextureState.Idle;
		Codec = null;
		Width = 0u;
		Height = 0u;
		LastFrameUnixMs = 0uL;
		Error = null;
	}

	protected StreamTextureStatus(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StreamTextureStatus(StreamTextureStatus source)
	{
		State = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.State);
		Codec = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Codec);
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
		Height = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Height);
		LastFrameUnixMs = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LastFrameUnixMs);
		Error = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Error);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
