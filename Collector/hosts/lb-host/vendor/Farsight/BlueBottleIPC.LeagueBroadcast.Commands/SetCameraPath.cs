using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8DCD6AE2DF6BA307CB99B9375512A1913441DCFE072CCC729E09A9FE0F57880E;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraPath")]
public class SetCameraPath : IFlatBufferSerializable<SetCameraPath>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<CameraPathKeyframe>? Keys { get; set; }

	public static ISerializer<SetCameraPath> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetCameraPath>)this).Serializer;

	ISerializer<SetCameraPath> IFlatBufferSerializable<SetCameraPath>.Serializer => Serializer;

	private static readonly ISerializer<SetCameraPath> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002ELazySerializer;

	static ISerializer<SetCameraPath> IFlatBufferSerializable<SetCameraPath>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002ELazySerializer;

	private static readonly ISerializer<SetCameraPath> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedySerializer;

	static ISerializer<SetCameraPath> IFlatBufferSerializable<SetCameraPath>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedySerializer;

	private static readonly ISerializer<SetCameraPath> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedyMutableSerializer;

	static ISerializer<SetCameraPath> IFlatBufferSerializable<SetCameraPath>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetCameraPath> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EProgressiveSerializer;

	static ISerializer<SetCameraPath> IFlatBufferSerializable<SetCameraPath>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EProgressiveSerializer;

	static SetCameraPath()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraPath_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetCameraPath()
	{
		Keys = null;
	}

	protected SetCameraPath(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetCameraPath(SetCameraPath source)
	{
		Keys = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Keys);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
