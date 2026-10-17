using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AutoDirectorPresentation")]
public class AutoDirectorPresentation
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong RequestedRevision { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong AppliedRevision { get; set; }

	[FlatBufferItem(3)]
	public virtual float AppliedGameTime { get; set; }

	[FlatBufferItem(4)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(5)]
	public virtual uint FramedHeroMask { get; set; }

	[FlatBufferItem(6)]
	public virtual bool Deferred { get; set; }

	static AutoDirectorPresentation()
	{
	}

	public AutoDirectorPresentation()
	{
		Enabled = false;
		RequestedRevision = 0uL;
		AppliedRevision = 0uL;
		AppliedGameTime = 0f;
		GameTime = 0f;
		FramedHeroMask = 0u;
		Deferred = false;
	}

	protected AutoDirectorPresentation(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AutoDirectorPresentation(AutoDirectorPresentation source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		RequestedRevision = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestedRevision);
		AppliedRevision = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AppliedRevision);
		AppliedGameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AppliedGameTime);
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		FramedHeroMask = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FramedHeroMask);
		Deferred = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Deferred);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
