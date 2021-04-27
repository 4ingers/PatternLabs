using System;
using System.Collections.Generic;

namespace PatternLabs.Sortings.Strategies
{
    public interface ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer);

        protected static void Swap(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}