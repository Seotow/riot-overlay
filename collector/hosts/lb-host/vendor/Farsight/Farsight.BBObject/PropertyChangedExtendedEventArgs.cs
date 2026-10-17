using System.ComponentModel;

namespace Farsight.BBObject;

public class PropertyChangedExtendedEventArgs(string? propertyName, object? oldValue, object? newValue) : PropertyChangedEventArgs(propertyName)
{
	public object? OldValue { get; } = oldValue;

	public object? NewValue { get; } = newValue;
}
