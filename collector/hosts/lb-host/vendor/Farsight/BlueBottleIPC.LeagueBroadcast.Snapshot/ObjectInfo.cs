using System;
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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.ObjectInfo")]
public class ObjectInfo
{
	public bool IsNeutral => Team == 3;

	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual uint NetworkId { get; set; }

	[FlatBufferItem(2)]
	public virtual uint Index { get; set; }

	[FlatBufferItem(3, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Position { get; set; }

	[FlatBufferItem(4)]
	public virtual float Rotation { get; set; }

	[FlatBufferItem(5)]
	public virtual byte Team { get; set; }

	public override bool Equals(object? obj)
	{
		if (!(obj is ObjectInfo objectInfo))
		{
			return false;
		}
		if (NetworkId == objectInfo.NetworkId)
		{
			return Index == objectInfo.Index;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(NetworkId, Index);
	}

	public static bool operator ==(ObjectInfo? left, ObjectInfo? right)
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

	public static bool operator !=(ObjectInfo? left, ObjectInfo? right)
	{
		return !(left == right);
	}

	static ObjectInfo()
	{
	}

	public ObjectInfo()
	{
		NetworkId = 0u;
		Index = 0u;
		Rotation = 0f;
		Team = 0;
	}

	protected ObjectInfo(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ObjectInfo(ObjectInfo source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		NetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NetworkId);
		Index = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Index);
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
		Rotation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rotation);
		Team = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Team);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
