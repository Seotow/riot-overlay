using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SetComponent")]
public class SetComponent : IFlatBufferSerializable<SetComponent>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(1)]
	public virtual Component? Component { get; set; }

	public static ISerializer<SetComponent> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetComponent>)this).Serializer;

	ISerializer<SetComponent> IFlatBufferSerializable<SetComponent>.Serializer => Serializer;

	private static readonly ISerializer<SetComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002ELazySerializer;

	static ISerializer<SetComponent> IFlatBufferSerializable<SetComponent>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002ELazySerializer;

	private static readonly ISerializer<SetComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedySerializer;

	static ISerializer<SetComponent> IFlatBufferSerializable<SetComponent>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedySerializer;

	private static readonly ISerializer<SetComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedyMutableSerializer;

	static ISerializer<SetComponent> IFlatBufferSerializable<SetComponent>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EProgressiveSerializer;

	static ISerializer<SetComponent> IFlatBufferSerializable<SetComponent>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EProgressiveSerializer;

	static SetComponent()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESetComponent_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetComponent()
	{
		EntityId = 0uL;
		Component = null;
	}

	protected SetComponent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetComponent(SetComponent source)
	{
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		Component = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Component);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
