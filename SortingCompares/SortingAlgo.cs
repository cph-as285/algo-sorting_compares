using System;

namespace SortingCompares
{
    public class SortingAlgo
    {
        public virtual string Name()
        {
            throw new NotImplementedException();
        }

        public virtual int[] Sort(int[] arr)
        {
            throw new NotImplementedException();
        }


        protected static bool less(int v, int w)
        {
            return v < w;
        }

        protected static void exch(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j]; a[j] = t;
        }
    }
}