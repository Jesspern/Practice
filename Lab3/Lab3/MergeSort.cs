using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3.TypesSort;

namespace Lab3
{
	public sealed class MergeSort :
		TypesSort
	{
		public override T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparasion)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			return MerSort(collection, 0, collection.Length - 1, direction, comparasion);
		}

		private static void Mer<T>(T[] collection, int lowIndex, int middleIndex, int highIndex, SortDirection direction, Comparison<T> comparison)
		{
			var left = lowIndex;
			var right = middleIndex + 1;
			var tempArray = new T[highIndex - lowIndex + 1];
			var index = 0;

			while ((left <= middleIndex) && (right <= highIndex))
			{
				if (direction == SortDirection.Ascending ? comparison(collection[left], collection[right]) < 0 : comparison(collection[left], collection[right]) > 0)
				{
					tempArray[index] = collection[left];
					left++;
				}
				else
				{
					tempArray[index] = collection[right];
					right++;
				}

				index++;
			}

			for (var i = left; i <= middleIndex; i++)
			{
				tempArray[index] = collection[i];
				index++;
			}

			for (var i = right; i <= highIndex; i++)
			{
				tempArray[index] = collection[i];
				index++;
			}

			for (var i = 0; i < tempArray.Length; i++)
			{
				collection[lowIndex + i] = tempArray[i];
			}
		}

		private static T[] MerSort<T>(T[] collection, int lowIndex, int highIndex, SortDirection direction, Comparison<T> comparison)
		{
			if (lowIndex < highIndex)
			{
				var middleIndex = (lowIndex + highIndex) / 2;
				MerSort(collection, lowIndex, middleIndex, direction, comparison);
				MerSort(collection, middleIndex + 1, highIndex, direction, comparison);
				Mer(collection, lowIndex, middleIndex, highIndex, direction, comparison);
			}

			return collection;
		}
	}
}
