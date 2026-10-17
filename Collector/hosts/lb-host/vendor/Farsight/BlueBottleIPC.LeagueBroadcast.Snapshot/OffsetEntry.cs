using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.OffsetEntry")]
public class OffsetEntry
{
	[FlatBufferItem(0)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong Value { get; set; }

	static OffsetEntry()
	{
	}

	public OffsetEntry()
	{
		Id = 0u;
		Value = 0uL;
	}

	protected OffsetEntry(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public OffsetEntry(OffsetEntry source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Value);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
