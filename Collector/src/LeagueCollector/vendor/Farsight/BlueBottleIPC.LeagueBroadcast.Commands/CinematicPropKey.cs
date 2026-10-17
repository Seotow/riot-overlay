using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.CinematicPropKey")]
public class CinematicPropKey
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1)]
	public virtual Vector3? Position { get; set; }

	static CinematicPropKey()
	{
	}

	public CinematicPropKey()
	{
		Time = 0f;
		Position = null;
	}

	protected CinematicPropKey(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicPropKey(CinematicPropKey source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
