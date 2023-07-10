using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Comparer_Good<T> :
		IEqualityComparer<T>
	{
		public bool Equals(T? x, T? y)
		{
			{
				if (ReferenceEquals(x, y)) return true;
				if (ReferenceEquals(x, null)) return false;
				if (ReferenceEquals(y, null)) return false;
				if (x.GetType() != y.GetType()) return false;

				return x.Equals(y);
			}
		}

		public int GetHashCode([DisallowNull] T obj)
		{
			return obj.GetHashCode();
		}
	}
}
