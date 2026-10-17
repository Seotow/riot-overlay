using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC7FCB3E2D11259EBE6D9C8D4B99A1C3845F1D1BCE8056B0930EC194907A0E8FD;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.AssetDelete")]
public class AssetDelete : IFlatBufferSerializable<AssetDelete>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual AssetIdentifier? Ident { get; set; }

	public static ISerializer<AssetDelete> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AssetDelete>)this).Serializer;

	ISerializer<AssetDelete> IFlatBufferSerializable<AssetDelete>.Serializer => Serializer;

	private static readonly ISerializer<AssetDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002ELazySerializer;

	static ISerializer<AssetDelete> IFlatBufferSerializable<AssetDelete>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002ELazySerializer;

	private static readonly ISerializer<AssetDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedySerializer;

	static ISerializer<AssetDelete> IFlatBufferSerializable<AssetDelete>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedySerializer;

	private static readonly ISerializer<AssetDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedyMutableSerializer;

	static ISerializer<AssetDelete> IFlatBufferSerializable<AssetDelete>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AssetDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EProgressiveSerializer;

	static ISerializer<AssetDelete> IFlatBufferSerializable<AssetDelete>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EProgressiveSerializer;

	static AssetDelete()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EAssetDelete_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AssetDelete()
	{
		Ident = null;
	}

	protected AssetDelete(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AssetDelete(AssetDelete source)
	{
		Ident = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Ident);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
