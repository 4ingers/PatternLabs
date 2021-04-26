using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings.Strategies
{
    public class BubbleSort<T> : ISortingStrategy<T>
    {
        public BubbleSort(Func<T, object> selector, Func<object, int> comparer)
        {

        }

        public void Sort(T[] array, bool descending)
        {
            throw new NotImplementedException();
        }
    }
}
