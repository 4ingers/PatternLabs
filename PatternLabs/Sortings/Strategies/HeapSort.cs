using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings.Strategies
{
    public class HeapSort<T> : ISortingStrategy<T>
    {
        public void Sort(List<T> list, Func<T, T, int> comparer)
        {
            int n = list.Count;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(list, n, i, comparer);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                ISortingStrategy<T>.Swap(list, 0, i);

                // call max heapify on the reduced heap
                Heapify(list, i, 0, comparer);
            }
        }

        void Heapify(List<T> list, int n, int i, Func<T, T, int> comparer)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && comparer(list[l], list[largest]) == 1)
                largest = l;

            // If right child is larger than largest so far
            if (r < n && comparer(list[r], list[largest]) == 1)
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                ISortingStrategy<T>.Swap(list, i, largest);

                // Recursively heapify the affected sub-tree
                Heapify(list, n, largest, comparer);
            }
        }
    }
}
