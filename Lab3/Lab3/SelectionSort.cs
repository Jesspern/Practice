using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public sealed class SelectionSort :
		TypesSort
	{
		public override T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparison)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			for (var i = 0; i < collection.Length; i++)
			{
				var itemIndex = i;

				for (var j = i + 1; j < collection.Length; j++)
				{
					if (direction == SortDirection.Ascending ? comparison(collection[j], collection[itemIndex]) < 0 : comparison(collection[j], collection[itemIndex]) > 0)
					{
						itemIndex = j;
					}

				}
				(collection[itemIndex], collection[i]) = (collection[i], collection[itemIndex]);
			}

			return collection;
		}
	}
}
