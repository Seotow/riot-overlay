using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N36A57451B7B9C9B0898F9016D28E24E926B423FEDF4C73A3FA7D79A67F50FE8B;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetGizmoState")]
public class SetGizmoState : IFlatBufferSerializable<SetGizmoState>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual GizmoModeChange Mode { get; set; }

	[FlatBufferItem(1)]
	public virtual GizmoSpaceChange Space { get; set; }

	public static ISerializer<SetGizmoState> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetGizmoState>)this).Serializer;

	ISerializer<SetGizmoState> IFlatBufferSerializable<SetGizmoState>.Serializer => Serializer;

	private static readonly ISerializer<SetGizmoState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002ELazySerializer;

	static ISerializer<SetGizmoState> IFlatBufferSerializable<SetGizmoState>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002ELazySerializer;

	private static readonly ISerializer<SetGizmoState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedySerializer;

	static ISerializer<SetGizmoState> IFlatBufferSerializable<SetGizmoState>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedySerializer;

	private static readonly ISerializer<SetGizmoState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedyMutableSerializer;

	static ISerializer<SetGizmoState> IFlatBufferSerializable<SetGizmoState>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetGizmoState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EProgressiveSerializer;

	static ISerializer<SetGizmoState> IFlatBufferSerializable<SetGizmoState>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EProgressiveSerializer;

	static SetGizmoState()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetGizmoState_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetGizmoState()
	{
		Mode = GizmoModeChange.Keep;
		Space = GizmoSpaceChange.Keep;
	}

	protected SetGizmoState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetGizmoState(SetGizmoState source)
	{
		Mode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Mode);
		Space = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Space);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
