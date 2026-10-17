using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA12C419ED762ACDF4570EA836CA6AF4971A23F6824D03A0437AF35E049FE7F6E;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ScriptVariableOverride")]
public class ScriptVariableOverride : IFlatBufferSerializable<ScriptVariableOverride>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Value { get; set; }

	[FlatBufferItem(2)]
	public virtual ScriptVariableValue? TypedValue { get; set; }

	public static ISerializer<ScriptVariableOverride> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptVariableOverride>)this).Serializer;

	ISerializer<ScriptVariableOverride> IFlatBufferSerializable<ScriptVariableOverride>.Serializer => Serializer;

	private static readonly ISerializer<ScriptVariableOverride> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002ELazySerializer;

	static ISerializer<ScriptVariableOverride> IFlatBufferSerializable<ScriptVariableOverride>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptVariableOverride> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedySerializer;

	static ISerializer<ScriptVariableOverride> IFlatBufferSerializable<ScriptVariableOverride>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptVariableOverride> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptVariableOverride> IFlatBufferSerializable<ScriptVariableOverride>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptVariableOverride> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EProgressiveSerializer;

	static ISerializer<ScriptVariableOverride> IFlatBufferSerializable<ScriptVariableOverride>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EProgressiveSerializer;

	static ScriptVariableOverride()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptVariableOverride_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptVariableOverride()
	{
		Value = null;
		TypedValue = null;
	}

	protected ScriptVariableOverride(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptVariableOverride(ScriptVariableOverride source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Value);
		TypedValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TypedValue);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
