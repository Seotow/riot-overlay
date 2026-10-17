namespace Farsight.Entity;

public readonly record struct CinematicCameraPoseSnapshot(bool IsFreeCamera, float PositionX, float PositionY, float PositionZ, float Roll, float Pitch, float Yaw, float Zoom, float Fov, byte Channels);
