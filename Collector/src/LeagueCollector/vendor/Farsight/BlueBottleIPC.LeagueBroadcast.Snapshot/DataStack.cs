using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.DataStack")]
public class DataStack
{
	[FlatBufferItem(0)]
	public virtual string? SkinName { get; set; }

	[FlatBufferItem(1)]
	public virtual uint CharHash { get; set; }

	[FlatBufferItem(2)]
	public virtual uint SkinId { get; set; }

	static DataStack()
	{
	}

	public DataStack()
	{
		SkinName = null;
		CharHash = 0u;
		SkinId = 0u;
	}

	protected DataStack(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public DataStack(DataStack source)
	{
		SkinName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SkinName);
		CharHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CharHash);
		SkinId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SkinId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
