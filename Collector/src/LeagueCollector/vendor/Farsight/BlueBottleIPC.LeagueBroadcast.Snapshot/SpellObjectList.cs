using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.SpellObjectList")]
public class SpellObjectList
{
	[FlatBufferItem(0)]
	public virtual IList<SpellObjectEntry>? SpellObjects { get; set; }

	static SpellObjectList()
	{
	}

	public SpellObjectList()
	{
		SpellObjects = null;
	}

	protected SpellObjectList(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SpellObjectList(SpellObjectList source)
	{
		SpellObjects = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpellObjects);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
