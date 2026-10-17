using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CameraProperties")]
public class CameraProperties
{
	[FlatBufferItem(0)]
	public virtual bool IsUnlocked { get; set; }

	[FlatBufferItem(1)]
	public virtual float ZoomCurrent { get; set; }

	[FlatBufferItem(2)]
	public virtual float ZoomTarget { get; set; }

	[FlatBufferItem(3)]
	public virtual bool IsFpsCamera { get; set; }

	static CameraProperties()
	{
	}

	public CameraProperties()
	{
		IsUnlocked = false;
		ZoomCurrent = 0f;
		ZoomTarget = 0f;
		IsFpsCamera = false;
	}

	protected CameraProperties(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraProperties(CameraProperties source)
	{
		IsUnlocked = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsUnlocked);
		ZoomCurrent = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZoomCurrent);
		ZoomTarget = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZoomTarget);
		IsFpsCamera = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsFpsCamera);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
