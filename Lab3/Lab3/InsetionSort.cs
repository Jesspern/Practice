using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public sealed class InsertionSort :
		TypesSort
	{
		public override T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparison)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			for (int i = 0; i < collection.Length; i++)
			{
				var x = collection[i];
				var j = i;
				while (j > 0 && direction == SortDirection.Ascending ? comparison(collection[j - 1], x) > 0 : comparison(collection[j - 1], x) < 0)   
				{
					collection[j] = collection[j - 1];
					j--;
				}
				collection[j] = x;
			}

			return collection;
		}
	}
}
