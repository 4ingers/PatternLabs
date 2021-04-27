using System;
using System.Collections.Generic;

namespace PatternLabs.Sortings.Strategies
{
    public class MergeSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            InternalSort(list, 0, list.Count - 1, comparer);
        }

        private void InternalSort(List<T> list, int l, int r, Func<T, T, int> comparer)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                InternalSort(list, l, m, comparer);
                InternalSort(list, m + 1, r, comparer);

                // Merge the sorted halves
                Merge(list, l, m, r, comparer);
            }
        }

        private void Merge(List<T> arr, int l, int m, int r, Func<T, T, int> comparer)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            List<T> L = new List<T>(new T[n1]);
            List<T> R = new List<T>(new T[n2]);
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];

            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (comparer(L[i], R[j]) < 1)
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}