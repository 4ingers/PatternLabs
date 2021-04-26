namespace PatternLabs.Sortings.Strategies
{
    public interface ISortingStrategy<T>
    {
        public void Sort(T[] array, bool descending);
    }
}