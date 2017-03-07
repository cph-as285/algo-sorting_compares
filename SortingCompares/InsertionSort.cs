namespace SortingCompares
{
    public class InsertionSort : SortingAlgo
    {
        public override string Name()
        {
            return "Insertion Sort";
        }

        public override int[] Sort(int[] arr)
        {
            int N = arr.Length;
            for (int i = 1; i < N; i++)
            { 
                for (int j = i; j > 0 && less(arr[j], arr[j - 1]); j--)
                    exch(arr, j, j - 1);
            }
            return arr;
        }
    }
}