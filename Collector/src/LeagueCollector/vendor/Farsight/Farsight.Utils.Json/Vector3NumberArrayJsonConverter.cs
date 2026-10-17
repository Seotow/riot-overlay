using System;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

public class Vector3NumberArrayJsonConverter : JsonConverter<Vector3>
{
	public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			throw new JsonException();
		}
		reader.Read();
		float value;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value = 0f;
		}
		else if (!reader.TryGetSingle(out value))
		{
			return Vector3.Zero;
		}
		reader.Read();
		float value2;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value2 = 0f;
		}
		else if (!reader.TryGetSingle(out value2))
		{
			return new Vector3(value, 0f, 0f);
		}
		reader.Read();
		float value3;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value3 = 0f;
		}
		else if (!reader.TryGetSingle(out value3))
		{
			return new Vector3(value, value2, 0f);
		}
		reader.Read();
		if (reader.TokenType != JsonTokenType.EndArray)
		{
			throw new JsonException();
		}
		return new Vector3(value, value2, value3);
	}

	public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		if (float.IsNaN(value.X) || float.IsInfinity(value.X))
		{
			writer.WriteStringValue(value.X.ToString());
		}
		else
		{
			writer.WriteNumberValue(value.X);
		}
		if (float.IsNaN(value.Y) || float.IsInfinity(value.Y))
		{
			writer.WriteStringValue(value.Y.ToString());
		}
		else
		{
			writer.WriteNumberValue(value.Y);
		}
		if (float.IsNaN(value.Z) || float.IsInfinity(value.Z))
		{
			writer.WriteStringValue(value.Z.ToString());
		}
		else
		{
			writer.WriteNumberValue(value.Z);
		}
		writer.WriteEndArray();
	}
}
