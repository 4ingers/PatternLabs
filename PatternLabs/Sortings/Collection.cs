using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PatternLabs.Sortings.Strategies;

namespace PatternLabs.Sortings
{
    public class Collection<T> : IEnumerable<T>, ICloneable
    {
        private readonly List<T> collection = new List<T>();
        public Func<T, T, int> Comparer { get; set; }

        public ISortingStrategy<T> SortingStrategy { get; set; } = new BubbleSort<T>();

        public object Clone()
        {
            var newCollection = new Collection<T>();
            collection.ForEach(x => newCollection.Add(x));
            return newCollection;
        }

        public void Add(T item)
        {
            collection.Add(item);
        }

        public IEnumerator<T> GetEnumerator() => collection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Sort()
        {
            if (Comparer == null)
            {
                throw new ArgumentNullException();
            }
            SortingStrategy.Sort(collection, Comparer);
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            collection.ForEach(x => sb.Append(x.ToString() + " "));
            Console.WriteLine(sb.ToString());
        }
    }
}