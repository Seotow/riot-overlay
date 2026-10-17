using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8E91FCCE8F44E8FC2DB97EAACF3C381BCDA33FE55421526745A51B3A02166220;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.AssetCreate")]
public class AssetCreate : IFlatBufferSerializable<AssetCreate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual AssetType Type { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Path { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong? Id { get; set; }

	[FlatBufferItem(3)]
	public virtual string? Name { get; set; }

	public static ISerializer<AssetCreate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AssetCreate>)this).Serializer;

	ISerializer<AssetCreate> IFlatBufferSerializable<AssetCreate>.Serializer => Serializer;

	private static readonly ISerializer<AssetCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002ELazySerializer;

	static ISerializer<AssetCreate> IFlatBufferSerializable<AssetCreate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002ELazySerializer;

	private static readonly ISerializer<AssetCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedySerializer;

	static ISerializer<AssetCreate> IFlatBufferSerializable<AssetCreate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedySerializer;

	private static readonly ISerializer<AssetCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedyMutableSerializer;

	static ISerializer<AssetCreate> IFlatBufferSerializable<AssetCreate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AssetCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EProgressiveSerializer;

	static ISerializer<AssetCreate> IFlatBufferSerializable<AssetCreate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EProgressiveSerializer;

	static AssetCreate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetCreate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AssetCreate()
	{
		Type = AssetType.texture;
		Path = null;
		Id = null;
		Name = null;
	}

	protected AssetCreate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AssetCreate(AssetCreate source)
	{
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		Path = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Path);
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
