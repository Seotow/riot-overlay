using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptVariableSnapshot")]
public class ScriptVariableSnapshot : IFlatBufferSerializable<ScriptVariableSnapshot>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Type { get; set; }

	[FlatBufferItem(2)]
	public virtual string? DefaultValue { get; set; }

	[FlatBufferItem(3)]
	public virtual string? DisplayName { get; set; }

	[FlatBufferItem(4)]
	public virtual ScriptVariableValue? TypedValue { get; set; }

	[FlatBufferItem(5)]
	public virtual string? EnumType { get; set; }

	[FlatBufferItem(6)]
	public virtual IList<ScriptVariableEnumOption>? EnumOptions { get; set; }

	public static ISerializer<ScriptVariableSnapshot> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptVariableSnapshot>)this).Serializer;

	ISerializer<ScriptVariableSnapshot> IFlatBufferSerializable<ScriptVariableSnapshot>.Serializer => Serializer;

	private static readonly ISerializer<ScriptVariableSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002ELazySerializer;

	static ISerializer<ScriptVariableSnapshot> IFlatBufferSerializable<ScriptVariableSnapshot>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptVariableSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedySerializer;

	static ISerializer<ScriptVariableSnapshot> IFlatBufferSerializable<ScriptVariableSnapshot>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptVariableSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptVariableSnapshot> IFlatBufferSerializable<ScriptVariableSnapshot>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptVariableSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EProgressiveSerializer;

	static ISerializer<ScriptVariableSnapshot> IFlatBufferSerializable<ScriptVariableSnapshot>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EProgressiveSerializer;

	static ScriptVariableSnapshot()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariableSnapshot_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptVariableSnapshot()
	{
		Type = null;
		DefaultValue = null;
		DisplayName = null;
		TypedValue = null;
		EnumType = null;
		EnumOptions = null;
	}

	protected ScriptVariableSnapshot(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptVariableSnapshot(ScriptVariableSnapshot source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		DefaultValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DefaultValue);
		DisplayName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DisplayName);
		TypedValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TypedValue);
		EnumType = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EnumType);
		EnumOptions = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EnumOptions);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
