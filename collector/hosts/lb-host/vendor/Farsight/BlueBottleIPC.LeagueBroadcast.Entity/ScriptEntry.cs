using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N9C439CEFA7EA2847C80F49BDC3B675BCB6D5ED3A07B88BFED482A1A8F2A1A5A5;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ScriptEntry")]
public class ScriptEntry : IFlatBufferSerializable<ScriptEntry>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Content { get; set; }

	[FlatBufferItem(2, DefaultValue = true)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(3)]
	public virtual string? ScriptId { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<ScriptVariableOverride>? VariableOverrides { get; set; }

	public static ISerializer<ScriptEntry> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptEntry>)this).Serializer;

	ISerializer<ScriptEntry> IFlatBufferSerializable<ScriptEntry>.Serializer => Serializer;

	private static readonly ISerializer<ScriptEntry> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002ELazySerializer;

	static ISerializer<ScriptEntry> IFlatBufferSerializable<ScriptEntry>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptEntry> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedySerializer;

	static ISerializer<ScriptEntry> IFlatBufferSerializable<ScriptEntry>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptEntry> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptEntry> IFlatBufferSerializable<ScriptEntry>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptEntry> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EProgressiveSerializer;

	static ISerializer<ScriptEntry> IFlatBufferSerializable<ScriptEntry>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EProgressiveSerializer;

	static ScriptEntry()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EScriptEntry_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptEntry()
	{
		Name = null;
		Content = null;
		Enabled = true;
		ScriptId = null;
		VariableOverrides = null;
	}

	protected ScriptEntry(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptEntry(ScriptEntry source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Content = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Content);
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		ScriptId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptId);
		VariableOverrides = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VariableOverrides);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
