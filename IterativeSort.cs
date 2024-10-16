namespace SortingAlgorithms
{
    /// <summary>
    /// Class for sorting algorithms with an iterative sorting algorithm
    /// </summary>
    internal class IterativeSort : ISort<int>
    {
        /// <summary>
        /// Sorts a list of integers in ascending order using the bubble sort algorithm.
        /// </summary>
        public void Sort(List<int> values)
        {
            int temp;

            for (int i = 1; i < values.Count; i++)
            {
                for (int j = 0; j < values.Count - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
        }
    }
}
