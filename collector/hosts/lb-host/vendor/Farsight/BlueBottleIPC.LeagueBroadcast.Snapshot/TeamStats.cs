using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.TeamStats")]
public class TeamStats
{
	[FlatBufferItem(0)]
	public virtual byte TowersLost { get; set; }

	static TeamStats()
	{
	}

	public TeamStats()
	{
		TowersLost = 0;
	}

	protected TeamStats(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public TeamStats(TeamStats source)
	{
		TowersLost = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TowersLost);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
