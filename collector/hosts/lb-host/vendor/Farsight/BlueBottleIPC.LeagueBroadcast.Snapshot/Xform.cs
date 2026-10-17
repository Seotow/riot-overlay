using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Xform")]
public class Xform
{
	[FlatBufferItem(0)]
	public virtual Vector3 Position { get; set; }

	[FlatBufferItem(1)]
	public virtual Vector3 Scale { get; set; }

	[FlatBufferItem(2)]
	public virtual Vector4 Rotation { get; set; }

	static Xform()
	{
	}

	public Xform()
	{
		Position = default;
		Scale = default;
		Rotation = default;
	}

	protected Xform(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Xform(Xform source)
	{
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
		Scale = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scale);
		Rotation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rotation);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
