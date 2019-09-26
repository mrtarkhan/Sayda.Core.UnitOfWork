using System.Collections.Generic;

namespace Sayda.Core.UnitOfWork
{
	public static class Extensions
	{
		public static void TryAdd<T, V> (this Dictionary<T, V> dictionary, T key, V value)
		{
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, value);
			}
		}
	}
}
