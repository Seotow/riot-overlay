using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum CameraPreviewError : byte
{
	None,
	UnsupportedBuild,
	Unavailable,
	Busy,
	StaleGeneration,
	InvalidIdentifier,
	DuplicateIdentifier,
	CameraLimitExceeded,
	OutputLimitExceeded,
	InvalidReference,
	InvalidController,
	InvalidLayout,
	InvalidGradient,
	NativeRegistrationFailure,
	RenderTargetFailure,
	CompositorFailure
}
