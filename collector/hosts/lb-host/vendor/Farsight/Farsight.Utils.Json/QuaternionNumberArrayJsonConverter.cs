using System;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

public class QuaternionNumberArrayJsonConverter : JsonConverter<Quaternion>
{
	public override Quaternion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			return default;
		}
		reader.Read();
		float value;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value = 0f;
		}
		else if (!reader.TryGetSingle(out value))
		{
			return Quaternion.Identity;
		}
		reader.Read();
		float value2;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value2 = 0f;
		}
		else if (!reader.TryGetSingle(out value2))
		{
			return new Quaternion(value, 0f, 0f, 0f);
		}
		reader.Read();
		float value3;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value3 = 0f;
		}
		else if (!reader.TryGetSingle(out value3))
		{
			return new Quaternion(value, value2, 0f, 0f);
		}
		reader.Read();
		float value4;
		if (reader.TokenType == JsonTokenType.Null)
		{
			value4 = 0f;
		}
		else if (!reader.TryGetSingle(out value4))
		{
			return new Quaternion(value, value2, value3, 0f);
		}
		reader.Read();
		return new Quaternion(value, value2, value3, value4);
	}

	public override void Write(Utf8JsonWriter writer, Quaternion value, JsonSerializerOptions options)
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
		if (float.IsNaN(value.W) || float.IsInfinity(value.W))
		{
			writer.WriteStringValue(value.W.ToString());
		}
		else
		{
			writer.WriteNumberValue(value.W);
		}
		writer.WriteEndArray();
	}
}
