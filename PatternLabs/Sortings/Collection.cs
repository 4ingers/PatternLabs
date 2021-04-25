using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PatternLabs.Sortings
{
    public class Collection<T> : IEnumerable<T>, ICloneable
    {
        private readonly T[] collection;

        public object Clone() => collection.Clone();

        public IEnumerator<T> GetEnumerator() => collection.GetEnumerator() as IEnumerator<T>;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
