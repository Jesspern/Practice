using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public abstract class TypesSort
	{
		public enum SortDirection
		{
			Ascending,
			Descending
		}

		public enum SortType
		{
			IsertionSort,
			SelectionSort,
			QuickSort,
			HeapSort,
			MergeSort
		}

		public abstract T[] Sort<T>(T[]? collection, SortDirection direction, Comparison<T> comparison);
	}
}
