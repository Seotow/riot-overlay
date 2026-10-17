using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.ObjectAddressEntry")]
public class ObjectAddressEntry
{
	[FlatBufferItem(0)]
	public virtual uint NetworkId { get; set; }

	[FlatBufferItem(1)]
	public virtual uint Index { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong Type { get; set; }

	[FlatBufferItem(3)]
	public virtual ulong Address { get; set; }

	static ObjectAddressEntry()
	{
	}

	public ObjectAddressEntry()
	{
		NetworkId = 0u;
		Index = 0u;
		Type = 0uL;
		Address = 0uL;
	}

	protected ObjectAddressEntry(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ObjectAddressEntry(ObjectAddressEntry source)
	{
		NetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NetworkId);
		Index = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Index);
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		Address = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Address);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
