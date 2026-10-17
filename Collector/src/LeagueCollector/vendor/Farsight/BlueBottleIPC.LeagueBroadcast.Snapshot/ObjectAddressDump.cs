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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.ObjectAddressDump")]
public class ObjectAddressDump
{
	[FlatBufferItem(0)]
	public virtual IList<ObjectAddressEntry>? Entries { get; set; }

	static ObjectAddressDump()
	{
	}

	public ObjectAddressDump()
	{
		Entries = null;
	}

	protected ObjectAddressDump(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ObjectAddressDump(ObjectAddressDump source)
	{
		Entries = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Entries);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
