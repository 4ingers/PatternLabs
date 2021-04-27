using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings.Strategies
{
    public class InsertionSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            int n = list.Count;
            for (int i = 1; i < n; ++i)
            {
                var key = list[i];
                int j = i - 1;

                // Move elements of list[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && comparer(list[j], key) == 1)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }
    }
}
