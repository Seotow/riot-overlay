using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Buff")]
public class Buff
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1)]
	public virtual float StartTime { get; set; }

	[FlatBufferItem(2)]
	public virtual float EndTime { get; set; }

	[FlatBufferItem(3)]
	public virtual uint Count { get; set; }

	[FlatBufferItem(4)]
	public virtual sbyte Type { get; set; }

	static Buff()
	{
	}

	public Buff()
	{
		Name = null;
		StartTime = 0f;
		EndTime = 0f;
		Count = 0u;
		Type = 0;
	}

	protected Buff(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Buff(Buff source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		StartTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StartTime);
		EndTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EndTime);
		Count = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Count);
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
