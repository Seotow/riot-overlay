using System;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

internal class CameraJsonConverter : JsonConverter<Camera>
{
	public override Camera? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}

	public override void Write(Utf8JsonWriter writer, Camera value, JsonSerializerOptions options)
	{
		Vector3 position = value.GetPosition();
		Quaternion rotation = value.GetRotation();
		Vector3 forward = value.GetForward();
		float foV = value.GetFoV();
		float aspectRatio = value.GetAspectRatio();
		float nearPlane = value.GetNearPlane();
		float farPlane = value.GetFarPlane();
		writer.WriteStartObject();
		writer.WritePropertyName("size");
		writer.WriteStartObject();
		writer.WriteNumber("width", value.ScreenX);
		writer.WriteNumber("height", value.ScreenY);
		writer.WriteEndObject();
		writer.WritePropertyName("position");
		writer.WriteStartObject();
		writer.WriteNumber("x", position.X);
		writer.WriteNumber("y", position.Y);
		writer.WriteNumber("z", position.Z);
		writer.WriteEndObject();
		writer.WriteStartObject("rotation");
		writer.WriteNumber("x", rotation.X);
		writer.WriteNumber("y", rotation.Y);
		writer.WriteNumber("z", rotation.Z);
		writer.WriteNumber("w", rotation.W);
		writer.WriteEndObject();
		writer.WritePropertyName("forward");
		writer.WriteStartObject();
		writer.WriteNumber("x", forward.X);
		writer.WriteNumber("y", forward.Y);
		writer.WriteNumber("z", forward.Z);
		writer.WriteEndObject();
		writer.WriteNumber("fov", foV);
		writer.WriteNumber("aspectRatio", aspectRatio);
		writer.WriteNumber("nearPlane", nearPlane);
		writer.WriteNumber("farPlane", farPlane);
		writer.WritePropertyName("viewProj");
		JsonSerializer.Serialize(writer, value.ViewProj, options);
		writer.WriteEndObject();
	}
}
