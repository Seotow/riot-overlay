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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.OffsetDump")]
public class OffsetDump
{
	[FlatBufferItem(0)]
	public virtual IList<OffsetEntry>? Entries { get; set; }

	static OffsetDump()
	{
	}

	public OffsetDump()
	{
		Entries = null;
	}

	protected OffsetDump(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public OffsetDump(OffsetDump source)
	{
		Entries = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Entries);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
