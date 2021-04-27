using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings.Strategies
{
    public class BubbleSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparer(list[j], list[j + 1]) == 1)
                    {
                        ISortingStrategy<T>.Swap(list, j, j + 1);
                    }
                }
            }
        }
    }
}
