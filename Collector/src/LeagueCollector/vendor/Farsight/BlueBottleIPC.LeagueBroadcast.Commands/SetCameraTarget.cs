using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N52EB91BD7A17EC617418054C4E97F1DCE17DC002DFB0E421CA9B9520B2D064D0;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetCameraTarget")]
public class SetCameraTarget : IFlatBufferSerializable<SetCameraTarget>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual Vector3? Pos { get; set; }

	[FlatBufferItem(1)]
	public virtual float RotYaw { get; set; }

	[FlatBufferItem(2)]
	public virtual float RotPitch { get; set; }

	[FlatBufferItem(3)]
	public virtual float RotRoll { get; set; }

	[FlatBufferItem(4)]
	public virtual Vector3? Vel { get; set; }

	[FlatBufferItem(5)]
	public virtual bool IsTeleport { get; set; }

	[FlatBufferItem(6)]
	public virtual uint Sequence { get; set; }

	public static ISerializer<SetCameraTarget> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetCameraTarget>)this).Serializer;

	ISerializer<SetCameraTarget> IFlatBufferSerializable<SetCameraTarget>.Serializer => Serializer;

	private static readonly ISerializer<SetCameraTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002ELazySerializer;

	static ISerializer<SetCameraTarget> IFlatBufferSerializable<SetCameraTarget>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002ELazySerializer;

	private static readonly ISerializer<SetCameraTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedySerializer;

	static ISerializer<SetCameraTarget> IFlatBufferSerializable<SetCameraTarget>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedySerializer;

	private static readonly ISerializer<SetCameraTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedyMutableSerializer;

	static ISerializer<SetCameraTarget> IFlatBufferSerializable<SetCameraTarget>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetCameraTarget> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EProgressiveSerializer;

	static ISerializer<SetCameraTarget> IFlatBufferSerializable<SetCameraTarget>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EProgressiveSerializer;

	static SetCameraTarget()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetCameraTarget_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetCameraTarget()
	{
		Pos = null;
		RotYaw = 0f;
		RotPitch = 0f;
		RotRoll = 0f;
		Vel = null;
		IsTeleport = false;
		Sequence = 0u;
	}

	protected SetCameraTarget(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetCameraTarget(SetCameraTarget source)
	{
		Pos = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Pos);
		RotYaw = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotYaw);
		RotPitch = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotPitch);
		RotRoll = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotRoll);
		Vel = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Vel);
		IsTeleport = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsTeleport);
		Sequence = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Sequence);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
