using System;

namespace Farsight;

public class CameraStateEventArgs : EventArgs
{
	public float PosX { get; set; }

	public float PosY { get; set; }

	public float PosZ { get; set; }

	public float RotYaw { get; set; }

	public float RotPitch { get; set; }

	public float RotRoll { get; set; }

	public float VelX { get; set; }

	public float VelY { get; set; }

	public float VelZ { get; set; }

	public bool IsTeleport { get; set; }

	public ulong UtcTimestamp { get; set; }

	public uint Sequence { get; set; }
}
