using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 39, 78, 56, 36, 24, 25, 15, 15, 89, 71 };
            int i, j, t;
            for (i = 0; i < a.Length - 1; i++)
                for (j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
            for (i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
    }
}
