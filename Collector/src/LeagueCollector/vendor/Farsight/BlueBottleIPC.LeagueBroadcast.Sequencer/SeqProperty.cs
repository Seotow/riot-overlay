using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(ushort))]
public enum SeqProperty : ushort
{
	TransformPosition,
	TransformRotation,
	TransformScale,
	VisibilityVisible,
	VisibilityOpacity,
	MeshAnimationTime,
	MeshAnimationSpeed,
	MeshAnimationLoop,
	MeshAnimationPlaying,
	DecalAngleThreshold,
	TextColor,
	SpriteTint,
	SpriteWidth,
	SpriteHeight,
	CameraPosition,
	CameraRotation,
	CameraZoom,
	CameraFov,
	CameraLookAtTarget,
	CameraAimBlend
}
