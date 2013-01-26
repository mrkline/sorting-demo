using System;

namespace Sorting
{
    public static class ArrayExtensions
    {
        public static void Shuffle (this int[] arr)
        {
            Random rng = new Random();
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
        }

        public static bool IsSorted(this int[] arr)
        {
            for (int c = 1; c < arr.Length; ++c)
            {
                if (arr[c - 1] > arr[c])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Swap(this int[] arr, int a, int b)
        {
            int c = arr[b];
            arr[b] = arr[a];
            arr[a] = c;
        }
    }
}