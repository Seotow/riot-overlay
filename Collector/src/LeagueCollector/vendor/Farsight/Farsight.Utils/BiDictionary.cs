using System;
using System.Collections;
using System.Collections.Generic;

namespace Farsight.Utils;

public class BiDictionary<TFirst, TSecond> : IEnumerable<BiDictionary<TFirst, TSecond>.Pair>, IEnumerable where TFirst : notnull where TSecond : notnull
{
	public struct Pair
	{
		public TFirst First;

		public TSecond Second;
	}

	public struct Enumerator(Dictionary<TFirst, TSecond>.Enumerator dictEnumerator) : IEnumerator<Pair>, IEnumerator, IDisposable
	{
		private Dictionary<TFirst, TSecond>.Enumerator _dictEnumerator = dictEnumerator;

		public Pair Current
		{
			get
			{
				Pair result = default;
				result.First = _dictEnumerator.Current.Key;
				result.Second = _dictEnumerator.Current.Value;
				return result;
			}
		}

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_dictEnumerator.Dispose();
		}

		public bool MoveNext()
		{
			return _dictEnumerator.MoveNext();
		}

		public void Reset()
		{
			throw new NotSupportedException();
		}
	}

	private readonly Dictionary<TFirst, TSecond> _firstToSecond = new Dictionary<TFirst, TSecond>();

	private readonly Dictionary<TSecond, TFirst> _secondToFirst = new Dictionary<TSecond, TFirst>();

	public int Count => _firstToSecond.Count;

	public void Add(TFirst first, TSecond second)
	{
		if (_firstToSecond.ContainsKey(first) || _secondToFirst.ContainsKey(second))
		{
			throw new ArgumentException("Duplicate first or second");
		}
		_firstToSecond.Add(first, second);
		_secondToFirst.Add(second, first);
	}

	public TSecond GetByFirst(TFirst first)
	{
		if (!_firstToSecond.TryGetValue(first, out var value))
		{
			throw new ArgumentException(null, "first");
		}
		return value;
	}

	public TFirst GetBySecond(TSecond second)
	{
		if (!_secondToFirst.TryGetValue(second, out var value))
		{
			throw new ArgumentException(null, "second");
		}
		return value;
	}

	public void RemoveByFirst(TFirst first)
	{
		if (!_firstToSecond.TryGetValue(first, out var value))
		{
			throw new ArgumentException(null, "first");
		}
		_firstToSecond.Remove(first);
		_secondToFirst.Remove(value);
	}

	public void RemoveBySecond(TSecond second)
	{
		if (!_secondToFirst.TryGetValue(second, out var value))
		{
			throw new ArgumentException(null, "second");
		}
		_secondToFirst.Remove(second);
		_firstToSecond.Remove(value);
	}

	public bool TryAdd(TFirst first, TSecond second)
	{
		if (_firstToSecond.ContainsKey(first) || _secondToFirst.ContainsKey(second))
		{
			return false;
		}
		_firstToSecond.Add(first, second);
		_secondToFirst.Add(second, first);
		return true;
	}

	public bool ContainsFirst(TFirst first)
	{
		return _firstToSecond.ContainsKey(first);
	}

	public bool ContainsSecond(TSecond second)
	{
		return _secondToFirst.ContainsKey(second);
	}

	public bool TryGetByFirst(TFirst first, out TSecond? second)
	{
		return _firstToSecond.TryGetValue(first, out second);
	}

	public bool TryGetBySecond(TSecond second, out TFirst? first)
	{
		return _secondToFirst.TryGetValue(second, out first);
	}

	public bool TryRemoveByFirst(TFirst first)
	{
		if (!_firstToSecond.TryGetValue(first, out var value))
		{
			return false;
		}
		_firstToSecond.Remove(first);
		_secondToFirst.Remove(value);
		return true;
	}

	public bool TryRemoveBySecond(TSecond second)
	{
		if (!_secondToFirst.TryGetValue(second, out var value))
		{
			return false;
		}
		_secondToFirst.Remove(second);
		_firstToSecond.Remove(value);
		return true;
	}

	public void Clear()
	{
		_firstToSecond.Clear();
		_secondToFirst.Clear();
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(_firstToSecond.GetEnumerator());
	}

	IEnumerator<Pair> IEnumerable<BiDictionary<TFirst, TSecond>.Pair>.GetEnumerator()
	{
		return GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
