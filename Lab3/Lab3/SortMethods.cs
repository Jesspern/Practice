using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3.TypesSort;

namespace Lab3
{
	public static class SortMethods
	{
		public static T[] Sort<T>(T[]? collection, TypesSort.SortDirection direction, TypesSort.SortType algor, SortType sortType) where T : IComparable<T>
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			switch(algor)
			{
				case TypesSort.SortType.IsertionSort:
					TypesSort typesort = new InsertionSort();
					return typesort.Sort(collection, direction, (x, y) => x.CompareTo(y));
				case TypesSort.SortType.QuickSort:
					TypesSort typesort1 = new QuickSort();
					return typesort1.Sort(collection, direction, (x, y) => x.CompareTo(y));
				case TypesSort.SortType.SelectionSort:
					TypesSort typesort2 = new SelectionSort();
					return typesort2.Sort(collection, direction, (x, y) => x.CompareTo(y));
				case TypesSort.SortType.HeapSort:
					TypesSort typesort3 = new HeapSort();
					return typesort3.Sort(collection, direction, (x, y) => x.CompareTo(y));
				case TypesSort.SortType.MergeSort:
					TypesSort typesort4 = new MergeSort();
					return typesort4.Sort(collection, direction, (x, y) => x.CompareTo(y));
				default: 
					throw new ArgumentException(nameof(algor), nameof(collection));

			}
		}

		public static T[] Sort<T>(T[]? collection, TypesSort.SortDirection direction, TypesSort.SortType algor, SortType sortType, IComparer<T> comparer)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			switch (algor)
			{
				case TypesSort.SortType.IsertionSort:
					TypesSort typesort = new InsertionSort();
					return typesort.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.QuickSort:
					TypesSort typesort1 = new QuickSort();
					return typesort1.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.SelectionSort:
					TypesSort typesort2 = new SelectionSort();
					return typesort2.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.HeapSort:
					TypesSort typesort3 = new HeapSort();
					return typesort3.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.MergeSort:
					TypesSort typesort4 = new MergeSort();
					return typesort4.Sort(collection, direction, comparer.Compare);
				default:
					throw new ArgumentException(nameof(algor), nameof(collection));

			}
		}

		public static T[] Sort<T>(T[]? collection, TypesSort.SortDirection direction, TypesSort.SortType algor, SortType sortType, Comparer<T> comparer)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			switch (algor)
			{
				case TypesSort.SortType.IsertionSort:
					TypesSort typesort = new InsertionSort();
					return typesort.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.QuickSort:
					TypesSort typesort1 = new QuickSort();
					return typesort1.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.SelectionSort:
					TypesSort typesort2 = new SelectionSort();
					return typesort2.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.HeapSort:
					TypesSort typesort3 = new HeapSort();
					return typesort3.Sort(collection, direction, comparer.Compare);
				case TypesSort.SortType.MergeSort:
					TypesSort typesort4 = new MergeSort();
					return typesort4.Sort(collection, direction, comparer.Compare);
				default:
					throw new ArgumentException(nameof(algor), nameof(collection));

			}
		}

		public static T[] Sort<T>(T[]? collection, TypesSort.SortDirection direction, TypesSort.SortType algor, SortType sortType, Comparison<T> comparer)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));

			switch (algor)
			{
				case TypesSort.SortType.IsertionSort:
					TypesSort typesort = new InsertionSort();
					return typesort.Sort(collection, direction, comparer);
				case TypesSort.SortType.QuickSort:
					TypesSort typesort1 = new QuickSort();
					return typesort1.Sort(collection, direction, comparer);
				case TypesSort.SortType.SelectionSort:
					TypesSort typesort2 = new SelectionSort();
					return typesort2.Sort(collection, direction, comparer);
				case TypesSort.SortType.HeapSort:
					TypesSort typesort3 = new HeapSort();
					return typesort3.Sort(collection, direction, comparer);
				case TypesSort.SortType.MergeSort:
					TypesSort typesort4 = new MergeSort();
					return typesort4.Sort(collection, direction, comparer);
				default:
					throw new ArgumentException(nameof(algor), nameof(collection));

			}
		}


	}
}
