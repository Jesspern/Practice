using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	using System;
	using System.ComponentModel;
	using static Lab3.TypesSort;

	public sealed class HeapSort :
		TypesSort
	{
		public override T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparasion)
		{
			if (collection == null)	throw new ArgumentNullException(nameof(collection));

			int length = collection.Length;

			for (int i = length / 2 - 1; i >= 0; i--)
				heapify(collection, length, i, direction, comparasion);

			for (int i = length - 1; i >= 0; i--)
			{

				(collection[0], collection[i]) = (collection[i], collection[0]);

				heapify(collection, i, 0, direction, comparasion);
			}

			return collection;
		}

		private static void heapify<T>(T[] collection, int length, int i, SortDirection direction, Comparison<T> comparison)
		{
			int largest = i;
			int l = 2 * i + 1;
			int r = 2 * i + 2;

			if (l < length && direction == SortDirection.Ascending ? comparison(collection[l], collection[largest]) > 0 : comparison(collection[l], collection[largest]) < 0)
				largest = l;

			if (r < length && direction == SortDirection.Ascending ? comparison(collection[r], collection[largest]) > 0 : comparison(collection[r], collection[largest]) < 0)
				largest = r;

			if (largest != i)
			{
				(collection[i], collection[largest]) = (collection[largest], collection[i]);

				heapify(collection, length, largest, direction, comparison);
			}
		}
	}

}
