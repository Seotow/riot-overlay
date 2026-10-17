using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.MiscObjects")]
public class MiscObjects : ISortableTable<ulong>
{
	[FlatBufferItem(0, Key = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "key", "0")]
	public virtual ulong Type { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<ObjectInfo>? Info { get; set; }

	static MiscObjects()
	{
		SortedVectorHelpers.RegisterKeyLookup((MiscObjects x) => x.Type, 0);
	}

	public MiscObjects()
	{
		Type = 0uL;
		Info = null;
	}

	protected MiscObjects(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public MiscObjects(MiscObjects source)
	{
		Type = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Type);
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
