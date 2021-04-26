using PatternLabs.Sortings.Strategies;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PatternLabs.Sortings
{
    public class Collection<T> : IEnumerable<T>, ICloneable
    {
        private readonly T[] collection;

        public ISortingStrategy<T> SortingStrategy { get; set; } = new BubbleSort<T>();

        public object Clone() => collection.Clone();

        public IEnumerator<T> GetEnumerator() => collection.GetEnumerator() as IEnumerator<T>;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Sort(bool descending = false)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            SortingStrategy.Sort(collection, descending);
        }
    }
}