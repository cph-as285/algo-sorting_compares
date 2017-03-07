namespace SortingCompares
{
    public class SelectionSort : SortingAlgo
    {
        public override string Name()
        {
            return "Selection Sort";
        }

        public override int[] Sort(int[] arr)
        {
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (less(arr[j], arr[min])) min = j;
                exch(arr, i, min);
            }
            return arr;
        }
    }
}