using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferEnum(typeof(byte))]
public enum ComponentKind : byte
{
	Transform,
	Visibility,
	EditState,
	Script,
	MeshRenderer,
	DecalProjector,
	TextRenderer,
	StreamSource,
	SpriteRenderer,
	UnitAnchor
}
