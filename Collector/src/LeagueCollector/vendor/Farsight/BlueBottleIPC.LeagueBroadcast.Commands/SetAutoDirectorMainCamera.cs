using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NDCAE36E5BED36ABA3FAE09FAF8E83A3AC5CED00125C67ACC7EFA597EC9CE6598;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetAutoDirectorMainCamera")]
public class SetAutoDirectorMainCamera : IFlatBufferSerializable<SetAutoDirectorMainCamera>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual CameraPreviewDirectorController? Controller { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong Revision { get; set; }

	public static ISerializer<SetAutoDirectorMainCamera> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetAutoDirectorMainCamera>)this).Serializer;

	ISerializer<SetAutoDirectorMainCamera> IFlatBufferSerializable<SetAutoDirectorMainCamera>.Serializer => Serializer;

	private static readonly ISerializer<SetAutoDirectorMainCamera> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002ELazySerializer;

	static ISerializer<SetAutoDirectorMainCamera> IFlatBufferSerializable<SetAutoDirectorMainCamera>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002ELazySerializer;

	private static readonly ISerializer<SetAutoDirectorMainCamera> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedySerializer;

	static ISerializer<SetAutoDirectorMainCamera> IFlatBufferSerializable<SetAutoDirectorMainCamera>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedySerializer;

	private static readonly ISerializer<SetAutoDirectorMainCamera> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedyMutableSerializer;

	static ISerializer<SetAutoDirectorMainCamera> IFlatBufferSerializable<SetAutoDirectorMainCamera>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetAutoDirectorMainCamera> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EProgressiveSerializer;

	static ISerializer<SetAutoDirectorMainCamera> IFlatBufferSerializable<SetAutoDirectorMainCamera>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EProgressiveSerializer;

	static SetAutoDirectorMainCamera()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetAutoDirectorMainCamera_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetAutoDirectorMainCamera()
	{
		Enabled = false;
		Controller = null;
		Revision = 0uL;
	}

	protected SetAutoDirectorMainCamera(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetAutoDirectorMainCamera(SetAutoDirectorMainCamera source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		Controller = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Controller);
		Revision = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Revision);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
