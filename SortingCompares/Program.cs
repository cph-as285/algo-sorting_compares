using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace SortingCompares
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectionSort = new SelectionSort();
            var insertionSort = new InsertionSort();

            var sorts = new List<SortingAlgo> {selectionSort, insertionSort};

            foreach (var sort in sorts)
            {
                long time = 0;
                int n = 1000;
                long prevTime = 0;
                while (time < 10000)
                {
                    var arr = Randomizer.CreateRandomNumbers(n);

                    var sw = new Stopwatch();
                    sw.Start();
                    arr = sort.Sort(arr);
                    sw.Stop();

                    if(!IsSorted(arr))
                        throw new InvalidOperationException();

                    time = sw.ElapsedMilliseconds;

                    string ratio = "N/A";
                    if (prevTime != 0)
                        ratio = ((double) time / prevTime).ToString(CultureInfo.InvariantCulture);

                    prevTime = time;
                    Console.WriteLine($"N: {n} \t-\t ElapsedTime: {time} \t-\t Sorting Algo: {sort.Name()} \t-\t Ratio to prev: {ratio}");
                    n *= 2;
                }
                Console.WriteLine();
            }
        }

        static bool IsSorted(int[] arr)
        {
            int prev = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < prev)
                    return false;
                prev = arr[i];
            }
            return true;
        }
    }
}
