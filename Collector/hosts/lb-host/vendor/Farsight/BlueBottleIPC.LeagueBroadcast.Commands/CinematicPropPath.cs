using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CinematicPropPath")]
public class CinematicPropPath
{
	[FlatBufferItem(0)]
	public virtual string? PropId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<CinematicPropKey>? Keys { get; set; }

	static CinematicPropPath()
	{
	}

	public CinematicPropPath()
	{
		PropId = null;
		Keys = null;
	}

	protected CinematicPropPath(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicPropPath(CinematicPropPath source)
	{
		PropId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PropId);
		Keys = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Keys);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
