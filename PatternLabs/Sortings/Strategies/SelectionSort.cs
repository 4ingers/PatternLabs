using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings.Strategies
{
    public class SelectionSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            int n = list.Count;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (comparer(list[j], list[min_idx]) == 1)
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                T temp = list[min_idx];
                list[min_idx] = list[i];
                list[i] = temp;
            }
        }
    }
}
