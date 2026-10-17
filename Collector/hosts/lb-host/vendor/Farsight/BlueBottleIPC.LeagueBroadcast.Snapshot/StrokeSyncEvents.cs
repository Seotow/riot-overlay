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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.StrokeSyncEvents")]
public class StrokeSyncEvents
{
	[FlatBufferItem(0)]
	public virtual IList<StrokeSyncEvent>? Events { get; set; }

	static StrokeSyncEvents()
	{
	}

	public StrokeSyncEvents()
	{
		Events = null;
	}

	protected StrokeSyncEvents(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public StrokeSyncEvents(StrokeSyncEvents source)
	{
		Events = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Events);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
