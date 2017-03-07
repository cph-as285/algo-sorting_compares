using System;

namespace SortingCompares
{
    public class Randomizer
    {
        public static int[] CreateRandomNumbers(int n)
        {
            var r = new Random();

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(n*2);
            }

            return arr;
        }
    }
}