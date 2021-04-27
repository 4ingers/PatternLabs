using System;
using System.Collections.Generic;

namespace PatternLabs.Sortings.Strategies
{
    public class QuickSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            Quick(list, 0, list.Count - 1, comparer);
        }

        private void Quick(List<T> arr, int left, int right, Func<T, T, int> comparer)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right, comparer);

                if (pivot > 1)
                {
                    Quick(arr, left, pivot - 1, comparer);
                }
                if (pivot + 1 < right)
                {
                    Quick(arr, pivot + 1, right, comparer);
                }
            }
        }

        private static int Partition(List<T> arr, int left, int right, Func<T, T, int> comparer)
        {
            T pivot = arr[left];
            while (true)
            {
                while (comparer(arr[left], pivot) == -1)
                {
                    left++;
                }

                while (comparer(arr[right], pivot) == 1)
                {
                    right--;
                }

                if (left < right)
                {
                    if (comparer(arr[left], arr[right]) == 0) return right;

                    T temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}