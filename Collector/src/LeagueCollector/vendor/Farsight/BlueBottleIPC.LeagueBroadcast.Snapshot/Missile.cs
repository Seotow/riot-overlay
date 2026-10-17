using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Missile")]
public class Missile
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1)]
	public virtual uint SourceIdx { get; set; }

	[FlatBufferItem(2)]
	public virtual uint TargetIdx { get; set; }

	[FlatBufferItem(3)]
	public virtual Vector3? StartPos { get; set; }

	[FlatBufferItem(4)]
	public virtual Vector3? EndPos { get; set; }

	static Missile()
	{
	}

	public Missile()
	{
		SourceIdx = 0u;
		TargetIdx = 0u;
		StartPos = null;
		EndPos = null;
	}

	protected Missile(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Missile(Missile source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		SourceIdx = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SourceIdx);
		TargetIdx = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetIdx);
		StartPos = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StartPos);
		EndPos = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EndPos);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
