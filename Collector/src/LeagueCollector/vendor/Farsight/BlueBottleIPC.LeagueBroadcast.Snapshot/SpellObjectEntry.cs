using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.SpellObjectEntry")]
public class SpellObjectEntry
{
	[FlatBufferItem(0)]
	public virtual uint ElfHash { get; set; }

	[FlatBufferItem(1)]
	public virtual string? SpellName { get; set; }

	static SpellObjectEntry()
	{
	}

	public SpellObjectEntry()
	{
		ElfHash = 0u;
		SpellName = null;
	}

	protected SpellObjectEntry(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SpellObjectEntry(SpellObjectEntry source)
	{
		ElfHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ElfHash);
		SpellName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpellName);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
