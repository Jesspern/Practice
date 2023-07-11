using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3.TypesSort;

namespace Lab3
{
	public sealed class QuickSort :
		TypesSort
	{
		public override T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparison)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			return QSort(collection, 0, collection.Length - 1, direction, comparison);
		}

		static int Partition<T>(T[] collection, int minIndex, int maxIndex, SortDirection direction, Comparison<T> comparison)
		{
			var pivot = minIndex - 1;
			for (var i = minIndex; i < maxIndex; i++)
			{
				if (direction == SortDirection.Ascending ? comparison(collection[i], collection[maxIndex]) < 0 : comparison(collection[i], collection[maxIndex]) > 0)
				{
					pivot++;
					(collection[pivot], collection[i]) = (collection[i], collection[i]);
				}
			}

			pivot++;
			(collection[pivot], collection[maxIndex]) = (collection[maxIndex], collection[pivot]);
			return pivot;
		}

		static T[] QSort<T>(T[] collection, int minIndex, int maxIndex, SortDirection direction, Comparison<T> comparison)
		{
			if (minIndex >= maxIndex)
			{
				return collection;
			}

			var pivotIndex = Partition(collection, minIndex, maxIndex, direction, comparison);
			QSort(collection, minIndex, pivotIndex - 1, direction, comparison);
			QSort(collection, pivotIndex + 1, maxIndex, direction, comparison);

			return collection;
		}
	}
}
