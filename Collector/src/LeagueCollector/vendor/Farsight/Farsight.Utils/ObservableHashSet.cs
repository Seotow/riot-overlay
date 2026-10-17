using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Farsight.Utils;

public class ObservableHashSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, INotifyCollectionChanged, INotifyPropertyChanged
{
	private readonly HashSet<T> _hashSet;

	private bool _suppressNotifications;

	public int Count => _hashSet.Count;

	public bool IsReadOnly => ((ICollection<T>)_hashSet).IsReadOnly;

	public event NotifyCollectionChangedEventHandler? CollectionChanged;

	public event PropertyChangedEventHandler? PropertyChanged;

	public ObservableHashSet()
	{
		_hashSet = new HashSet<T>();
	}

	public ObservableHashSet(IEnumerable<T> collection)
	{
		HashSet<T> hashSet = new HashSet<T>();
		foreach (T item in collection)
		{
			hashSet.Add(item);
		}
		_hashSet = hashSet;
	}

	public ObservableHashSet(IEqualityComparer<T>? comparer)
	{
		_hashSet = new HashSet<T>(comparer);
	}

	public void ReplaceWith(IEnumerable<T> newItems)
	{
		_suppressNotifications = true;
		try
		{
			_hashSet.Clear();
			foreach (T newItem in newItems)
			{
				_hashSet.Add(newItem);
			}
		}
		finally
		{
			_suppressNotifications = false;
		}
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		OnPropertyChanged("Count");
	}

	public bool Add(T item)
	{
		if (_hashSet.Add(item))
		{
			if (!_suppressNotifications)
			{
				OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
				OnPropertyChanged("Count");
			}
			return true;
		}
		return false;
	}

	void ICollection<T>.Add(T item)
	{
		Add(item);
	}

	public void Clear()
	{
		if (_hashSet.Count != 0)
		{
			_hashSet.Clear();
			if (!_suppressNotifications)
			{
				OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
				OnPropertyChanged("Count");
			}
		}
	}

	public bool Contains(T item)
	{
		return _hashSet.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		_hashSet.CopyTo(array, arrayIndex);
	}

	public void ExceptWith(IEnumerable<T> other)
	{
		List<T> list = new List<T>();
		foreach (T item in other)
		{
			if (_hashSet.Remove(item))
			{
				list.Add(item);
			}
		}
		if (list.Count > 0 && !_suppressNotifications)
		{
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			OnPropertyChanged("Count");
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _hashSet.GetEnumerator();
	}

	public void IntersectWith(IEnumerable<T> other)
	{
		_hashSet.IntersectWith(other);
		if (!_suppressNotifications)
		{
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			OnPropertyChanged("Count");
		}
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		return _hashSet.IsProperSubsetOf(other);
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		return _hashSet.IsProperSupersetOf(other);
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		return _hashSet.IsSubsetOf(other);
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		return _hashSet.IsSupersetOf(other);
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		return _hashSet.Overlaps(other);
	}

	public bool Remove(T item)
	{
		if (_hashSet.Remove(item))
		{
			if (!_suppressNotifications)
			{
				OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
				OnPropertyChanged("Count");
			}
			return true;
		}
		return false;
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		return _hashSet.SetEquals(other);
	}

	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		_hashSet.SymmetricExceptWith(other);
		if (!_suppressNotifications)
		{
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			OnPropertyChanged("Count");
		}
	}

	public void UnionWith(IEnumerable<T> other)
	{
		List<T> list = new List<T>();
		foreach (T item in other)
		{
			if (_hashSet.Add(item))
			{
				list.Add(item);
			}
		}
		if (list.Count > 0 && !_suppressNotifications)
		{
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			OnPropertyChanged("Count");
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
		CollectionChanged?.Invoke(this, e);
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public static implicit operator HashSet<T>(ObservableHashSet<T> observableHashSet)
	{
		return observableHashSet._hashSet;
	}
}
