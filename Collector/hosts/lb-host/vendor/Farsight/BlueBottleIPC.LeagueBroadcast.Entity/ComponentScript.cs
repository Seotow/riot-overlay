using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentScript")]
public class ComponentScript : IFlatBufferSerializable<ComponentScript>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<ScriptEntry>? Scripts { get; set; }

	public static ISerializer<ComponentScript> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentScript>)this).Serializer;

	ISerializer<ComponentScript> IFlatBufferSerializable<ComponentScript>.Serializer => Serializer;

	private static readonly ISerializer<ComponentScript> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002ELazySerializer;

	static ISerializer<ComponentScript> IFlatBufferSerializable<ComponentScript>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentScript> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedySerializer;

	static ISerializer<ComponentScript> IFlatBufferSerializable<ComponentScript>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentScript> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentScript> IFlatBufferSerializable<ComponentScript>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentScript> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EProgressiveSerializer;

	static ISerializer<ComponentScript> IFlatBufferSerializable<ComponentScript>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EProgressiveSerializer;

	static ComponentScript()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentScript_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentScript()
	{
		Scripts = null;
	}

	protected ComponentScript(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentScript(ComponentScript source)
	{
		Scripts = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scripts);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
