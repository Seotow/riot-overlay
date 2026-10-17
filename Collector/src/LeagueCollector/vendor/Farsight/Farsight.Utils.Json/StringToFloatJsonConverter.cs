using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

public class StringToFloatJsonConverter : JsonConverter<float?>
{
	public override float? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			string text = reader.GetString();
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			if (text.Equals("null", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (float.TryParse(text, out var result))
			{
				return result;
			}
			return null;
		}
		return reader.GetSingle();
	}

	public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
	{
		if (value.HasValue)
		{
			writer.WriteNumberValue(value.Value);
		}
		else
		{
			writer.WriteNullValue();
		}
	}
}
