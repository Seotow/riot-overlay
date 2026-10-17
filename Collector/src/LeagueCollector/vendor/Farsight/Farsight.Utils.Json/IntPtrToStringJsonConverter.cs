using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

internal class IntPtrToStringJsonConverter : JsonConverter<nint>
{
	public override nint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string text = reader.GetString();
		if (text == null)
		{
			return 0;
		}
		return new IntPtr(long.Parse(text));
	}

	public override void Write(Utf8JsonWriter writer, nint value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(((IntPtr)value).ToString("X"));
	}
}
