using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue")]
public class ScriptVariableValue : IFlatBufferSerializable<ScriptVariableValue>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ScriptVariableValueType Type { get; set; }

	[FlatBufferItem(1)]
	public virtual bool BoolValue { get; set; }

	[FlatBufferItem(2)]
	public virtual long IntValue { get; set; }

	[FlatBufferItem(3)]
	public virtual ulong UintValue { get; set; }

	[FlatBufferItem(4)]
	public virtual double NumberValue { get; set; }

	[FlatBufferItem(5)]
	public virtual string? StringValue { get; set; }

	[FlatBufferItem(6)]
	public virtual Vector3? Vec3Value { get; set; }

	[FlatBufferItem(7)]
	public virtual Vector4? ColorValue { get; set; }

	[FlatBufferItem(8)]
	public virtual ScriptVariableValueType ArrayElementType { get; set; }

	[FlatBufferItem(9)]
	public virtual IList<ScriptVariableValue>? ArrayValues { get; set; }

	public static ISerializer<ScriptVariableValue> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptVariableValue>)this).Serializer;

	ISerializer<ScriptVariableValue> IFlatBufferSerializable<ScriptVariableValue>.Serializer => Serializer;

	private static readonly ISerializer<ScriptVariableValue> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002ELazySerializer;

	static ISerializer<ScriptVariableValue> IFlatBufferSerializable<ScriptVariableValue>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptVariableValue> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedySerializer;

	static ISerializer<ScriptVariableValue> IFlatBufferSerializable<ScriptVariableValue>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptVariableValue> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptVariableValue> IFlatBufferSerializable<ScriptVariableValue>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptVariableValue> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EProgressiveSerializer;

	static ISerializer<ScriptVariableValue> IFlatBufferSerializable<ScriptVariableValue>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EProgressiveSerializer;

	static ScriptVariableValue()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommon_002EScriptVariableValue_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptVariableValue()
	{
		Type = ScriptVariableValueType.None;
		BoolValue = false;
		IntValue = 0L;
		UintValue = 0uL;
		NumberValue = 0.0;
		StringValue = null;
		Vec3Value = null;
		ColorValue = null;
		ArrayElementType = ScriptVariableValueType.None;
		ArrayValues = null;
	}

	protected ScriptVariableValue(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptVariableValue(ScriptVariableValue source)
	{
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		BoolValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BoolValue);
		IntValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IntValue);
		UintValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.UintValue);
		NumberValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NumberValue);
		StringValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StringValue);
		Vec3Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Vec3Value);
		ColorValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ColorValue);
		ArrayElementType = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ArrayElementType);
		ArrayValues = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ArrayValues);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
