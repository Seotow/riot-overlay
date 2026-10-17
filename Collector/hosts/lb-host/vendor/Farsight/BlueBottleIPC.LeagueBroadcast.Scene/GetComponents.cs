using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.GetComponents")]
public class GetComponents : IFlatBufferSerializable<GetComponents>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(1)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_vector", "IList")]
	public virtual IList<ComponentKind>? Kinds { get; set; }

	public static ISerializer<GetComponents> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<GetComponents>)this).Serializer;

	ISerializer<GetComponents> IFlatBufferSerializable<GetComponents>.Serializer => Serializer;

	private static readonly ISerializer<GetComponents> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002ELazySerializer;

	static ISerializer<GetComponents> IFlatBufferSerializable<GetComponents>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002ELazySerializer;

	private static readonly ISerializer<GetComponents> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedySerializer;

	static ISerializer<GetComponents> IFlatBufferSerializable<GetComponents>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedySerializer;

	private static readonly ISerializer<GetComponents> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedyMutableSerializer;

	static ISerializer<GetComponents> IFlatBufferSerializable<GetComponents>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<GetComponents> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EProgressiveSerializer;

	static ISerializer<GetComponents> IFlatBufferSerializable<GetComponents>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EProgressiveSerializer;

	static GetComponents()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EGetComponents_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public GetComponents()
	{
		EntityId = 0uL;
		Kinds = null;
	}

	protected GetComponents(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public GetComponents(GetComponents source)
	{
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		Kinds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kinds);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
