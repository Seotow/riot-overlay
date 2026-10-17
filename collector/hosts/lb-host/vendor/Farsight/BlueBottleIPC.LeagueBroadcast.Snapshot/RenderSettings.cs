using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.RenderSettings")]
public class RenderSettings : IFlatBufferSerializable<RenderSettings>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool? FogOfWar { get; set; }

	public static ISerializer<RenderSettings> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<RenderSettings>)this).Serializer;

	ISerializer<RenderSettings> IFlatBufferSerializable<RenderSettings>.Serializer => Serializer;

	private static readonly ISerializer<RenderSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002ELazySerializer;

	static ISerializer<RenderSettings> IFlatBufferSerializable<RenderSettings>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002ELazySerializer;

	private static readonly ISerializer<RenderSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedySerializer;

	static ISerializer<RenderSettings> IFlatBufferSerializable<RenderSettings>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedySerializer;

	private static readonly ISerializer<RenderSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedyMutableSerializer;

	static ISerializer<RenderSettings> IFlatBufferSerializable<RenderSettings>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<RenderSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EProgressiveSerializer;

	static ISerializer<RenderSettings> IFlatBufferSerializable<RenderSettings>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EProgressiveSerializer;

	static RenderSettings()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ERenderSettings_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public RenderSettings()
	{
		FogOfWar = null;
	}

	protected RenderSettings(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public RenderSettings(RenderSettings source)
	{
		FogOfWar = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FogOfWar);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
