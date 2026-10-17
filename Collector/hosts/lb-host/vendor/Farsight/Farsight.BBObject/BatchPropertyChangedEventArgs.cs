using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Farsight.BBObject;

public class BatchPropertyChangedEventArgs : PropertyChangedEventArgs
{
	private readonly List<PropertyChange> _changes;

	public IReadOnlyList<PropertyChange> Changes => _changes;

	public IEnumerable<string> ChangedPropertyNames => _changes.Select((PropertyChange c) => c.PropertyName);

	public BatchPropertyChangedEventArgs(IEnumerable<PropertyChange> changes)
		: base(null)
	{
		_changes = changes.ToList();
	}

	public bool HasPropertyChanged(string propertyName)
	{
		return _changes.Any((PropertyChange c) => c.PropertyName == propertyName);
	}

	public PropertyChange? GetChange(string propertyName)
	{
		foreach (PropertyChange change in _changes)
		{
			if (change.PropertyName == propertyName)
			{
				return change;
			}
		}
		return null;
	}
}
