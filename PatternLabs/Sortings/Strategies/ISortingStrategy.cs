namespace PatternLabs.Sortings.Strategies
{
    public interface ISortingStrategy<T>
    {
        public void Sort(in T[] array, in ISortingStrategy<T> sortingStrategy, in bool descendingOrder = false);
    }
}