namespace Farsight.BBObject;

public readonly record struct PropertyChange(string PropertyName, object? OldValue, object? NewValue);
