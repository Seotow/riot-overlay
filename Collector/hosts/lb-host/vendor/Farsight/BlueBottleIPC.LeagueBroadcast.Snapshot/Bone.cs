using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Bone")]
public class Bone
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1)]
	public virtual Xform? Xform { get; set; }

	static Bone()
	{
	}

	public Bone()
	{
		Name = null;
		Xform = null;
	}

	protected Bone(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Bone(Bone source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Xform = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Xform);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
