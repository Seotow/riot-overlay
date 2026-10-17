using System;
using System.Collections.Generic;
using System.Linq;

namespace Farsight.Utils;

internal static class CollectionUtils
{
	public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
	{
		int num = 0;
		foreach (T item in ie)
		{
			action(item, num++);
		}
	}

	public static void Deconstruct<TKey, TElement>(this IGrouping<TKey, TElement> grouping, out TKey key, out IEnumerable<TElement> elements)
	{
		key = grouping.Key;
		elements = grouping;
	}
}
