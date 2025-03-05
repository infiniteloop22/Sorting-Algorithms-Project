namespace SortingAlgorithms
{
    /// <summary>
    /// Interface for sorting algorithms
    /// </summary>
    internal interface ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts a list of values
        /// </summary>
        void Sort(List<T> values);
    }
}