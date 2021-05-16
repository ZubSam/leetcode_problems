using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeApp.Microsoft_problems._10_05_2021
{
    class Problems
    {
        public void S3()
        {
            var n = 3;

            var a = new int[1] { 1 };
            var b = new int[1] { 3 };

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!dict.TryAdd(a[i], 1))
                {
                    dict[a[i]]++;
                }

                if (!dict.TryAdd(b[i], 1))
                {
                    dict[b[i]]++;
                }
            }

            dict = dict.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            var res = 0;

            foreach (var item in dict)
            {
                res += item.Value * n;
                n--;
            }

            Console.ReadKey();
        }

        public static int S1(int[] A)
        {
            int res = 0;
            Array.Sort(A);
            int m = A[A.Length / 2];
            foreach (var item in A)
            {
                res += Math.Abs(m - item);
            }
            return res;
        }

        public static void S2()
        {

            var A = new int[6] { 5, 5, 5, 5, 5, 5 };

            var listOfUsed = new List<int>();

            var x = 0;
            var y = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var j = i + 1;

                if (i == A.Length - 1)
                {
                    j = 0;
                }

                if (listOfUsed.Any(x => x == i || x == j))
                {
                    continue;
                }

                x = A[i];
                y = A[j];

                if ((x + y) % 2 == 0)
                {
                    listOfUsed.Add(i);
                    listOfUsed.Add(j);
                }
            }
            var t = 0;
        }
    }
}
