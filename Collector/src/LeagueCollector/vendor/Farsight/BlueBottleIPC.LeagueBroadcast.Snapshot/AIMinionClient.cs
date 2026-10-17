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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient")]
public class AIMinionClient
{
	public bool IsClone => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsClone);

	public bool IsLaneMinion => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsLaneMinion);

	public bool IsEliteMinion => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsEliteMinion);

	public bool IsEpicMinion => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsEpicMinion);

	public bool IsJungleMinion => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsJungleMinion);

	public bool IsWardOrPlant => TypeInfo.HasFlag(AIMinionClientTypeInfo.IsWardOrPlant);

	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required AIClient Common { get; set; }

	[FlatBufferItem(2)]
	public virtual AIMinionClientTypeInfo TypeInfo { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<Bone>? Bones { get; set; }

	public override bool Equals(object? obj)
	{
		if (!(obj is AIMinionClient aIMinionClient))
		{
			return false;
		}
		return Info.Equals(aIMinionClient.Info);
	}

	public override int GetHashCode()
	{
		return Info.GetHashCode();
	}

	public static bool operator ==(AIMinionClient? left, AIMinionClient? right)
	{
		if ((object)left == null && (object)right == null)
		{
			return true;
		}
		if ((object)left == null || (object)right == null)
		{
			return false;
		}
		return left.Equals(right);
	}

	public static bool operator !=(AIMinionClient? left, AIMinionClient? right)
	{
		return !(left == right);
	}

	static AIMinionClient()
	{
	}

	public AIMinionClient()
	{
		TypeInfo = (AIMinionClientTypeInfo)0;
		Bones = null;
	}

	protected AIMinionClient(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AIMinionClient(AIMinionClient source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		Common = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Common);
		TypeInfo = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TypeInfo);
		Bones = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Bones);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
