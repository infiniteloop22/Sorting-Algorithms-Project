namespace SortingAlgorithms
{
    /// <summary>
    /// Class for sorting algorithms with an iterative sorting algorithm
    /// </summary>
    internal class RecursiveSort : ISort<int>
    {
        /// <summary>
        /// Recursively sorts a list of integers using the merge sort algorithm.
        /// </summary>
        public void Sort(List<int> values)
        {
            List<int> leftHalf = new();
            List<int> rightHalf = new();
            int mid;
            if (values.Count == 1) return;

            mid = (values.Count / 2);
            leftHalf = values.Slice(0, mid);
            rightHalf = values.Slice(mid, values.Count - mid);

            Sort(leftHalf);
            Sort(rightHalf);

            Merge(values, leftHalf, rightHalf);
        }

        public List<int> Merge(List<int> values, List<int> leftHalf, List<int> rightHalf)
        {
            int i = 0;
            int j = 0;
            while (i < leftHalf.Count && j < rightHalf.Count)
            {
                if (leftHalf[i] < rightHalf[j])
                {
                    values.Add(leftHalf[i]);
                    i++;
                }
                else
                {
                    values.Add(rightHalf[j]);
                    j++;
                }
            }

            while (i < leftHalf.Count)
            {
                values.Add(leftHalf[i]);
                i++;
            }

            while (j < rightHalf.Count)
            {
                values.Add(rightHalf[j]);
                j++;
            }

            return values;
        }
    }
}
