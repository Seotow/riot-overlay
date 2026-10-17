using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[JsonConverter(typeof(CameraJsonConverter))]
[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Camera")]
public class Camera
{
	private BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4? InvViewMatrix;

	public BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4? ViewProj;

	private bool IsValid => InvViewMatrix.HasValue;

	[FlatBufferItem(0)]
	public virtual uint ScreenX { get; set; }

	[FlatBufferItem(1)]
	public virtual uint ScreenY { get; set; }

	[FlatBufferItem(2)]
	public virtual BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4? View { get; set; }

	[FlatBufferItem(3)]
	public virtual BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4? Proj { get; set; }

	[FlatBufferItem(4)]
	public virtual BlueBottleIPC.LeagueBroadcast.Common.Vector3? FocusPosition { get; set; }

	[FlatBufferItem(5)]
	public virtual AutoDirectorPresentation? AutoDirector { get; set; }

	private void InitExtensions()
	{
		BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4? matrix4x = ViewProj;
		if (matrix4x.HasValue)
		{
			matrix4x = InvViewMatrix;
			if (matrix4x.HasValue)
			{
				return;
			}
		}
		if (View.HasValue && Proj.HasValue)
		{
			matrix4x = InvViewMatrix;
			if (!matrix4x.HasValue)
			{
				InvViewMatrix = default(BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4);
				View.Value.Invert(out InvViewMatrix);
			}
			matrix4x = ViewProj;
			if (!matrix4x.HasValue)
			{
				ViewProj = default(BlueBottleIPC.LeagueBroadcast.Common.Matrix4x4);
				ViewProj = Proj.Value * View.Value;
			}
		}
	}

	public System.Numerics.Vector3 GetPosition()
	{
		InitExtensions();
		if (!IsValid)
		{
			return default;
		}
		BlueBottleIPC.LeagueBroadcast.Common.Vector4 row = InvViewMatrix.Value.GetRow(3);
		return new System.Numerics.Vector3
		{
			X = row.X,
			Y = row.Y,
			Z = row.Z
		};
	}

	public System.Numerics.Quaternion GetRotation()
	{
		InitExtensions();
		if (!IsValid)
		{
			return default;
		}
		return System.Numerics.Quaternion.CreateFromRotationMatrix(InvViewMatrix.Value.AsNumerics());
	}

	public System.Numerics.Vector3 GetForward()
	{
		InitExtensions();
		if (!IsValid)
		{
			return default;
		}
		BlueBottleIPC.LeagueBroadcast.Common.Vector4 row = InvViewMatrix.Value.GetRow(2);
		return new System.Numerics.Vector3
		{
			X = row.X,
			Y = row.Y,
			Z = row.Z
		};
	}

	public bool TryWorldToNdc(System.Numerics.Vector3 world, out float ndcX, out float ndcY)
	{
		ndcX = 0f;
		ndcY = 0f;
		InitExtensions();
		if (!View.HasValue || !Proj.HasValue)
		{
			return false;
		}
		System.Numerics.Matrix4x4 matrix = View.Value.AsNumerics();
		System.Numerics.Matrix4x4 matrix2 = Proj.Value.AsNumerics();
		System.Numerics.Vector4 vector = System.Numerics.Vector4.Transform(System.Numerics.Vector4.Transform(new System.Numerics.Vector4(world.X, world.Y, world.Z, 1f), matrix), matrix2);
		if (vector.W <= 1E-06f)
		{
			return false;
		}
		ndcX = vector.X / vector.W;
		ndcY = vector.Y / vector.W;
		return true;
	}

	public float GetFoV()
	{
		InitExtensions();
		if (!IsValid)
		{
			return 0f;
		}
		return float.RadiansToDegrees((float)Math.Atan(1f / Proj.Value[1, 1]) * 2f);
	}

	public float GetAspectRatio()
	{
		InitExtensions();
		if (!IsValid)
		{
			return 0f;
		}
		return Proj.Value[1, 1] / Proj.Value[0, 0];
	}

	public float GetNearPlane()
	{
		InitExtensions();
		if (!IsValid)
		{
			return 0f;
		}
		return Proj.Value[2, 2] / (Proj.Value[2, 2] - Proj.Value[2, 3]);
	}

	public float GetFarPlane()
	{
		InitExtensions();
		if (!IsValid)
		{
			return 0f;
		}
		return Proj.Value[2, 2] * Proj.Value[2, 3] / (Proj.Value[2, 2] - Proj.Value[2, 3]);
	}

	static Camera()
	{
	}

	public Camera()
	{
		ScreenX = 0u;
		ScreenY = 0u;
		View = null;
		Proj = null;
		FocusPosition = null;
		AutoDirector = null;
	}

	protected Camera(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Camera(Camera source)
	{
		ScreenX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScreenX);
		ScreenY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScreenY);
		View = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.View);
		Proj = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Proj);
		FocusPosition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FocusPosition);
		AutoDirector = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AutoDirector);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
