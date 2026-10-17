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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.ReplayFile")]
public class ReplayFile
{
	[FlatBufferItem(0)]
	public virtual IList<GameInfo>? Snapshots { get; set; }

	static ReplayFile()
	{
	}

	public ReplayFile()
	{
		Snapshots = null;
	}

	protected ReplayFile(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ReplayFile(ReplayFile source)
	{
		Snapshots = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Snapshots);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
