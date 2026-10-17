using System.Collections;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using FlatSharp.Attributes;

namespace LeagueCollector;

// Export schema fields only: computed Farsight properties contain lookups/caches
// and must not be traversed as if they were fields in the wire snapshot.
public static class SchemaJson
{
    private static readonly ConcurrentDictionary<Type, PropertyInfo[]> Properties = new();
    public static JsonNode? Convert(object? value, Type? declared = null, int depth = 0)
    {
        if (depth > 64) throw new InvalidDataException("Snapshot is too deep.");
        if (value == null) return null;
        Type t = Nullable.GetUnderlyingType(declared ?? value.GetType()) ?? declared ?? value.GetType();
        if (value is float f) return float.IsFinite(f) ? JsonValue.Create(f) : null;
        if (value is double d) return double.IsFinite(d) ? JsonValue.Create(d) : null;
        if (value is string s) return JsonValue.Create(s);
        if (t.IsEnum) return JsonValue.Create(System.Convert.ToInt64(value));
        if (t.IsPrimitive || value is decimal) return JsonSerializer.SerializeToNode(value, t, CollectorHub.Json);
        if (value is IEnumerable items)
        {
            Type? element = t.IsArray ? t.GetElementType() : t.IsGenericType ? t.GetGenericArguments().FirstOrDefault() : null;
            var array = new JsonArray();
            foreach (var item in items) array.Add(Convert(item, element, depth + 1));
            return array;
        }
        var result = new JsonObject();
        var props = Properties.GetOrAdd(t, type => type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.GetCustomAttribute<FlatBufferItemAttribute>(true) != null && p.GetIndexParameters().Length == 0)
            .OrderBy(p => p.GetCustomAttribute<FlatBufferItemAttribute>(true)!.Index).ToArray());
        foreach (var p in props) result[JsonNamingPolicy.CamelCase.ConvertName(p.Name)] = Convert(p.GetValue(value), p.PropertyType, depth + 1);
        // FlatBuffer value structs (Vector3, Matrix4x4...) use public fields.
        if (t.IsValueType)
            foreach (var field in t.GetFields(BindingFlags.Instance | BindingFlags.Public))
                result[JsonNamingPolicy.CamelCase.ConvertName(field.Name)] = Convert(field.GetValue(value), field.FieldType, depth + 1);
        return result;
    }
}
