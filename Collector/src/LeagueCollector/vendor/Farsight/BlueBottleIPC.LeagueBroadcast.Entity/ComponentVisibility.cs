using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentVisibility")]
public class ComponentVisibility : IFlatBufferSerializable<ComponentVisibility>, IFlatBufferSerializable
{
	[FlatBufferItem(0, DefaultValue = true)]
	public virtual bool Visible { get; set; }

	[FlatBufferItem(1, DefaultValue = 1f)]
	public virtual float Opacity { get; set; }

	public static ISerializer<ComponentVisibility> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentVisibility>)this).Serializer;

	ISerializer<ComponentVisibility> IFlatBufferSerializable<ComponentVisibility>.Serializer => Serializer;

	private static readonly ISerializer<ComponentVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002ELazySerializer;

	static ISerializer<ComponentVisibility> IFlatBufferSerializable<ComponentVisibility>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedySerializer;

	static ISerializer<ComponentVisibility> IFlatBufferSerializable<ComponentVisibility>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentVisibility> IFlatBufferSerializable<ComponentVisibility>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EProgressiveSerializer;

	static ISerializer<ComponentVisibility> IFlatBufferSerializable<ComponentVisibility>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EProgressiveSerializer;

	static ComponentVisibility()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentVisibility_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentVisibility()
	{
		Visible = true;
		Opacity = 1f;
	}

	protected ComponentVisibility(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentVisibility(ComponentVisibility source)
	{
		Visible = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Visible);
		Opacity = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Opacity);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
