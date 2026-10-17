using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Farsight.Utils;

public class ReadOnlyObservableHashSet<T>(ObservableHashSet<T> observableHashSet) : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, INotifyCollectionChanged, INotifyPropertyChanged
{
	private readonly ObservableHashSet<T> _observableHashSet = observableHashSet;

	public int Count => _observableHashSet.Count;

	public event NotifyCollectionChangedEventHandler? CollectionChanged
	{
		add
		{
			_observableHashSet.CollectionChanged += value;
		}
		remove
		{
			_observableHashSet.CollectionChanged -= value;
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged
	{
		add
		{
			_observableHashSet.PropertyChanged += value;
		}
		remove
		{
			_observableHashSet.PropertyChanged -= value;
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _observableHashSet.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
