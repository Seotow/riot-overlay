using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N6653D642A3BD1AB4F399EABB79121E79E2C33BFE9CFD67906A9C4D1D80BD7B56;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptVariable")]
public class ScriptVariable : IFlatBufferSerializable<ScriptVariable>, IFlatBufferSerializable
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

	public static ISerializer<ScriptVariable> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptVariable>)this).Serializer;

	ISerializer<ScriptVariable> IFlatBufferSerializable<ScriptVariable>.Serializer => Serializer;

	private static readonly ISerializer<ScriptVariable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002ELazySerializer;

	static ISerializer<ScriptVariable> IFlatBufferSerializable<ScriptVariable>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptVariable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedySerializer;

	static ISerializer<ScriptVariable> IFlatBufferSerializable<ScriptVariable>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptVariable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptVariable> IFlatBufferSerializable<ScriptVariable>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptVariable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EProgressiveSerializer;

	static ISerializer<ScriptVariable> IFlatBufferSerializable<ScriptVariable>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EProgressiveSerializer;

	static ScriptVariable()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptVariable_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptVariable()
	{
		Type = null;
		DefaultValue = null;
		DisplayName = null;
		TypedValue = null;
		EnumType = null;
		EnumOptions = null;
	}

	protected ScriptVariable(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptVariable(ScriptVariable source)
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
