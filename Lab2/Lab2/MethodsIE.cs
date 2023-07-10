using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

	public static class MethodsIE
	{

		private static IEnumerable<IEnumerable<T>> GetAllCombination<T>(this IEnumerable<T> collection, int k)
		{
			return k == 0 ? new[] { Array.Empty<T>() } :
				collection.SelectMany((e, i) =>
					collection.Skip(i).GetAllCombination(k - 1).Select(c => (new[] { e }).Concat(c)));
		}

		public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> collection, int count_repeats, IEqualityComparer<T>? comp)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));
			if (comp == null) throw new ArgumentNullException(nameof(comp));

			CheckElems(collection, comp);

			foreach (var item in GetAllCombination(collection, count_repeats))
			{
				yield return item;
			}
		}

		public static IEnumerable<IEnumerable<T>> GenSubset<T>(this IEnumerable<T>? collection, IEqualityComparer<T>? comp)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));
			if (comp == null) throw new ArgumentNullException(nameof(comp));

			CheckElems(collection, comp);

			var enumerable = collection.ToArray();

			var result = Enumerable
				.Range(0, 1 << enumerable.Length)
				.Select(index => enumerable.Where((type, element) => (index & (1 << element)) != 0).ToArray());

			foreach (var item in result)
			{
				yield return item;
			}
		}

		private static IEnumerable<IEnumerable<T>> GetAllPermutation<T>(this IEnumerable<T> collection)
		{
			if (collection.Count() == 1)
				return new[] { collection };

			return collection.SelectMany(v => GetAllPermutation(collection.Where(x => !x.Equals(v))), (v, p) => p.Prepend(v));
		}

		public static IEnumerable<IEnumerable<T>> GenPermutation<T>(this IEnumerable<T>? collection, IEqualityComparer<T>? comparer)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));
			if (comparer == null) throw new ArgumentNullException(nameof(comparer));

			CheckElems(collection, comparer);

			foreach (var item in GetAllPermutation(collection))
			{
				yield return item;
			}
		}

		private static void CheckElems<T>(this IEnumerable<T> values, IEqualityComparer<T> comp)
		{
			if (values.Distinct(comp).Count() != values.Count())
			{
				throw new ArgumentException(nameof(values));
			}
		}
	}
}
