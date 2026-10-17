using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.BBObject;

public static class ScriptVariableParser
{
	[GeneratedRegex("\\bclass\\s+Script\\b")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex ScriptClassRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ScriptClassRegex_0.Instance;
	}

	[GeneratedRegex("^\\s*(?:(public|private|protected)\\s+)?(array\\s*<\\s*[A-Za-z_]\\w*\\s*>|[A-Za-z_]\\w*)\\s+([A-Za-z_]\\w*)\\s*(?:=\\s*(.*?))?\\s*;\\s*(?://.*)?$")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex FieldRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__FieldRegex_1.Instance;
	}

	[GeneratedRegex("^array\\s*<\\s*([A-Za-z_]\\w*)\\s*>$")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex ArrayTypeRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ArrayTypeRegex_2.Instance;
	}

	[GeneratedRegex("\\benum\\s+([A-Za-z_]\\w*)\\s*\\{(.*?)\\}", RegexOptions.Singleline)]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex EnumRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__EnumRegex_3.Instance;
	}

	[GeneratedRegex("^Vec3\\s*\\((.*)\\)$")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex Vec3InitializerRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__Vec3InitializerRegex_4.Instance;
	}

	[GeneratedRegex("^Color\\s*\\((.*)\\)$")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.37416")]
	private static Regex ColorInitializerRegex()
	{
		return _003CRegexGenerator_g_003EF07DBEDF2A755CE16A3EB10D86B5DE3556406A2C370C212D61D326AA8431ED56C__ColorInitializerRegex_5.Instance;
	}

	public static List<ScriptVariable> Parse(string? content)
	{
		if (string.IsNullOrWhiteSpace(content))
		{
			return new List<ScriptVariable>();
		}
		List<ScriptVariable> list = new List<ScriptVariable>();
		Dictionary<string, List<ScriptVariableEnumOption>> dictionary = ParseEnums(content);
		int num = 0;
		int num2 = -1;
		bool flag = false;
		bool inBlockComment = false;
		string[] array = content.Split('\n');
		foreach (string text in array)
		{
			string text2 = StripStringsAndComments(text, ref inBlockComment);
			if (num2 < 0 && !flag && ScriptClassRegex().IsMatch(text2))
			{
				flag = true;
			}
			if (num2 >= 0 && num == num2)
			{
				Match match = FieldRegex().Match(text);
				string value = match.Groups[1].Value;
				bool flag2 = match.Success;
				if (flag2)
				{
					bool flag3 = ((value == "private" || value == "protected") ? true : false);
					flag2 = !flag3;
				}
				if (flag2)
				{
					string value2 = match.Groups[2].Value;
					Match match2 = ArrayTypeRegex().Match(value2);
					string text3 = (match2.Success ? match2.Groups[1].Value : value2);
					if (IsEditableType(text3, dictionary))
					{
						List<ScriptVariableEnumOption> list2 = (dictionary.TryGetValue(text3, out var value3) ? value3 : null);
						list.Add(new ScriptVariable
						{
							Name = match.Groups[3].Value,
							TypedValue = (match2.Success ? ParseArrayValue(text3, match.Groups[4].Value, list2) : ParseDefaultValue(text3, match.Groups[4].Value, list2)),
							EnumType = ((list2 != null) ? text3 : null),
							EnumOptions = list2?.Select((ScriptVariableEnumOption option) => new ScriptVariableEnumOption
							{
								Name = option.Name,
								Value = option.Value
							}).ToList()
						});
					}
				}
			}
			int num3 = text2.Count((char character) => character == '{');
			int num4 = text2.Count((char character) => character == '}');
			if (flag && num3 > 0)
			{
				num2 = num + 1;
				flag = false;
			}
			num += num3 - num4;
			if (num2 >= 0 && num < num2)
			{
				break;
			}
		}
		return list;
	}

	public static ScriptVariableValue? ParseLegacyValue(ScriptVariableValue template, string? raw)
	{
		if (raw == null)
		{
			raw = "";
		}
		switch (template.Type)
		{
		case ScriptVariableValueType.Bool:
		{
			if (bool.TryParse(raw, out var result4))
			{
				return new ScriptVariableValue
				{
					Type = ScriptVariableValueType.Bool,
					BoolValue = result4
				};
			}
			break;
		}
		case ScriptVariableValueType.Int:
		{
			if (long.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result2))
			{
				return new ScriptVariableValue
				{
					Type = ScriptVariableValueType.Int,
					IntValue = result2
				};
			}
			break;
		}
		case ScriptVariableValueType.UInt:
		{
			if (ulong.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result3))
			{
				return new ScriptVariableValue
				{
					Type = ScriptVariableValueType.UInt,
					UintValue = result3
				};
			}
			break;
		}
		case ScriptVariableValueType.Number:
		{
			if (double.TryParse(NormalizeNumber(raw), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				return new ScriptVariableValue
				{
					Type = ScriptVariableValueType.Number,
					NumberValue = result
				};
			}
			break;
		}
		case ScriptVariableValueType.String:
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.String,
				StringValue = raw
			};
		case ScriptVariableValueType.Vec3:
		{
			float[] array2 = ParseComponents(raw, 3);
			if (array2.Length != 3)
			{
				return null;
			}
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Vec3,
				Vec3Value = new Vector3
				{
					X = array2[0],
					Y = array2[1],
					Z = array2[2]
				}
			};
		}
		case ScriptVariableValueType.Color:
		{
			float[] array = ParseLegacyColor(raw);
			if (array.Length != 4)
			{
				return null;
			}
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Color,
				ColorValue = new Vector4
				{
					X = array[0],
					Y = array[1],
					Z = array[2],
					W = array[3]
				}
			};
		}
		}
		return null;
	}

	private static ScriptVariableValue ParseDefaultValue(string scriptType, string initializer, IReadOnlyList<ScriptVariableEnumOption>? enumOptions = null)
	{
		initializer = initializer.Trim();
		if (enumOptions != null)
		{
			string memberName = (initializer.Contains("::", StringComparison.Ordinal) ? initializer.Substring(initializer.LastIndexOf("::", StringComparison.Ordinal) + 2) : initializer);
			long intValue = enumOptions.FirstOrDefault((ScriptVariableEnumOption option) => option.Name == memberName)?.Value ?? (TryParseInteger(initializer, out var result) ? result : 0);
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Int,
				IntValue = intValue
			};
		}
		bool flag;
		switch (scriptType)
		{
		case "bool":
		{
			bool result2;
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Bool,
				BoolValue = (bool.TryParse(initializer, out result2) & result2)
			};
		}
		case "string":
		{
			string text;
			if (initializer.Length < 2 || !initializer.StartsWith('"') || !initializer.EndsWith('"'))
			{
				text = "";
			}
			else
			{
				string text2 = initializer;
				text = text2.Substring(1, text2.Length - 1 - 1);
			}
			string stringValue = text;
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.String,
				StringValue = stringValue
			};
		}
		case "Vec3":
		{
			Match match2 = Vec3InitializerRegex().Match(initializer);
			float[] source = (match2.Success ? match2.Groups[1].Value.Split(',').Select(ParseFloat).ToArray() : Array.Empty<float>());
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Vec3,
				Vec3Value = new Vector3
				{
					X = source.ElementAtOrDefault(0),
					Y = source.ElementAtOrDefault(1),
					Z = source.ElementAtOrDefault(2)
				}
			};
		}
		case "Color":
		{
			Match match = ColorInitializerRegex().Match(initializer);
			float[] array = (match.Success ? match.Groups[1].Value.Split(',').Select(ParseFloat).ToArray() : Array.Empty<float>());
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Color,
				ColorValue = new Vector4
				{
					X = ((array.Length != 0) ? array[0] : 1f),
					Y = ((array.Length > 1) ? array[1] : 1f),
					Z = ((array.Length > 2) ? array[2] : 1f),
					W = ((array.Length > 3) ? array[3] : 1f)
				}
			};
		}
		case "int":
		case "int64":
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			long.TryParse(initializer, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result3);
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.Int,
				IntValue = result3
			};
		}
		if ((scriptType == "uint" || scriptType == "uint64") ? true : false)
		{
			ulong.TryParse(initializer, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result4);
			return new ScriptVariableValue
			{
				Type = ScriptVariableValueType.UInt,
				UintValue = result4
			};
		}
		double.TryParse(NormalizeNumber(initializer), NumberStyles.Float, CultureInfo.InvariantCulture, out var result5);
		return new ScriptVariableValue
		{
			Type = ScriptVariableValueType.Number,
			NumberValue = result5
		};
	}

	private static ScriptVariableValue ParseArrayValue(string elementType, string initializer, IReadOnlyList<ScriptVariableEnumOption>? enumOptions)
	{
		List<ScriptVariableValue> list = new List<ScriptVariableValue>();
		string text = initializer.Trim();
		if (text.StartsWith('{') && text.EndsWith('}'))
		{
			string text2 = text;
			foreach (string item in SplitTopLevel(text2.Substring(1, text2.Length - 1 - 1)))
			{
				list.Add(ParseDefaultValue(elementType, item, enumOptions));
			}
		}
		return new ScriptVariableValue
		{
			Type = ScriptVariableValueType.Array,
			ArrayElementType = ParseDefaultValue(elementType, "", enumOptions).Type,
			ArrayValues = list
		};
	}

	private static bool IsEditableType(string scriptType, IReadOnlyDictionary<string, List<ScriptVariableEnumOption>> enums)
	{
		bool flag;
		switch (scriptType)
		{
		case "Vec3":
		case "bool":
		case "uint":
		case "Color":
		case "float":
		case "int64":
		case "double":
		case "string":
		case "uint64":
		case "int":
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (!flag)
		{
			return enums.ContainsKey(scriptType);
		}
		return true;
	}

	private static Dictionary<string, List<ScriptVariableEnumOption>> ParseEnums(string content)
	{
		Dictionary<string, List<ScriptVariableEnumOption>> dictionary = LoadBuiltInEnums();
		bool inBlockComment = false;
		string input = string.Join('\n', from line in content.Split('\n')
			select StripStringsAndComments(line, ref inBlockComment));
		foreach (Match item in EnumRegex().Matches(input))
		{
			List<ScriptVariableEnumOption> list = new List<ScriptVariableEnumOption>();
			long num = 0L;
			string[] array = item.Groups[2].Value.Split(',');
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				string[] array2 = array[num2].Split('=', 2, StringSplitOptions.TrimEntries);
				string text = array2[0].Trim();
				if (Regex.IsMatch(text, "^[A-Za-z_]\\w*$"))
				{
					if (array2.Length == 2 && TryParseInteger(array2[1], out var result))
					{
						num = result;
					}
					list.Add(new ScriptVariableEnumOption
					{
						Name = text,
						Value = num++
					});
				}
			}
			if (list.Count > 0)
			{
				dictionary[item.Groups[1].Value] = list;
			}
		}
		return dictionary;
	}

	private static Dictionary<string, List<ScriptVariableEnumOption>> LoadBuiltInEnums()
	{
		Dictionary<string, List<ScriptVariableEnumOption>> dictionary = new Dictionary<string, List<ScriptVariableEnumOption>>();
		using Stream stream = typeof(ScriptVariableParser).Assembly.GetManifestResourceStream("Farsight.angelscript-api.json");
		if (stream == null)
		{
			return dictionary;
		}
		using JsonDocument jsonDocument = JsonDocument.Parse(stream);
		foreach (JsonElement item in jsonDocument.RootElement.GetProperty("types").EnumerateArray())
		{
			if (!item.TryGetProperty("members", out var value))
			{
				continue;
			}
			string text = item.GetProperty("label").GetString() ?? "";
			List<ScriptVariableEnumOption> list = new List<ScriptVariableEnumOption>();
			int num = 0;
			foreach (JsonElement item2 in value.EnumerateArray())
			{
				if (item2.GetProperty("detail").GetString() != text + " value")
				{
					list.Clear();
					break;
				}
				list.Add(new ScriptVariableEnumOption
				{
					Name = (item2.GetProperty("label").GetString() ?? ""),
					Value = (item2.TryGetProperty("value", out var value2) ? value2.GetInt64() : num)
				});
				num++;
			}
			if (list.Count > 0)
			{
				dictionary[text] = list;
			}
		}
		return dictionary;
	}

	private static bool TryParseInteger(string value, out long result)
	{
		value = value.Trim();
		if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			return long.TryParse(value.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
		}
		return long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
	}

	private static List<string> SplitTopLevel(string value)
	{
		List<string> list = new List<string>();
		int num = 0;
		int num2 = 0;
		char c = '\0';
		bool flag = false;
		for (int i = 0; i < value.Length; i++)
		{
			char c2 = value[i];
			if (c != '\0')
			{
				if (!flag && c2 == c)
				{
					c = '\0';
				}
				flag = !flag && c2 == '\\';
			}
			else if ((c2 == '"' || c2 == '\'') ? true : false)
			{
				c = c2;
			}
			else if ((c2 == '(' || c2 == '[' || c2 == '{') ? true : false)
			{
				num2++;
			}
			else if ((c2 == ')' || c2 == ']' || c2 == '}') ? true : false)
			{
				num2--;
			}
			else if (c2 == ',' && num2 == 0)
			{
				int num3 = num;
				list.Add(value.Substring(num3, i - num3).Trim());
				num = i + 1;
			}
		}
		string text = value.Substring(num).Trim();
		if (text.Length > 0)
		{
			list.Add(text);
		}
		return list;
	}

	private static float ParseFloat(string value)
	{
		if (!float.TryParse(NormalizeNumber(value), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
		{
			return 0f;
		}
		return result;
	}

	private static float[] ParseComponents(string value, int expectedCount)
	{
		string[] array = value.Split(',');
		if (array.Length != expectedCount)
		{
			return Array.Empty<float>();
		}
		float[] array2 = new float[expectedCount];
		for (int i = 0; i < array.Length; i++)
		{
			if (!float.TryParse(NormalizeNumber(array[i]), NumberStyles.Float, CultureInfo.InvariantCulture, out array2[i]))
			{
				return Array.Empty<float>();
			}
		}
		return array2;
	}

	private static float[] ParseLegacyColor(string value)
	{
		string text = value.TrimStart('#');
		int length = text.Length;
		bool flag = ((length == 6 || length == 8) ? true : false);
		if (flag && uint.TryParse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result))
		{
			if (text.Length == 6)
			{
				result = (result << 8) | 0xFF;
			}
			return new float[4]
			{
				(float)((result >> 24) & 0xFF) / 255f,
				(float)((result >> 16) & 0xFF) / 255f,
				(float)((result >> 8) & 0xFF) / 255f,
				(float)(result & 0xFF) / 255f
			};
		}
		return ParseComponents(value, 4);
	}

	private static string NormalizeNumber(string value)
	{
		value = value.Trim();
		if (!value.EndsWith('f') && !value.EndsWith('F') && !value.EndsWith('d') && !value.EndsWith('D'))
		{
			return value;
		}
		string text = value;
		return text.Substring(0, text.Length - 1);
	}

	private static string StripStringsAndComments(string line, ref bool inBlockComment)
	{
		StringBuilder stringBuilder = new StringBuilder(line.Length);
		bool flag = false;
		char c = '\0';
		bool flag2 = false;
		for (int i = 0; i < line.Length; i++)
		{
			char c2 = line[i];
			char c3 = ((i + 1 < line.Length) ? line[i + 1] : '\0');
			if (inBlockComment)
			{
				if (c2 == '*' && c3 == '/')
				{
					inBlockComment = false;
					stringBuilder.Append("  ");
					i++;
				}
				else
				{
					stringBuilder.Append(' ');
				}
				continue;
			}
			if (flag)
			{
				stringBuilder.Append(' ');
				if (!flag2 && c2 == c)
				{
					flag = false;
				}
				flag2 = !flag2 && c2 == '\\';
				continue;
			}
			if (c2 == '/' && c3 == '/')
			{
				stringBuilder.Append(' ', line.Length - i);
				break;
			}
			if (c2 == '/' && c3 == '*')
			{
				inBlockComment = true;
				stringBuilder.Append("  ");
				i++;
			}
			else if ((c2 == '"' || c2 == '\'') ? true : false)
			{
				flag = true;
				c = c2;
				flag2 = false;
				stringBuilder.Append(' ');
			}
			else
			{
				stringBuilder.Append(c2);
			}
		}
		return stringBuilder.ToString();
	}
}
