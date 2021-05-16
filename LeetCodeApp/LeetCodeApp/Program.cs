using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace LeetCodeApp
{
    class Program
    {

        public static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();


            S33();
        }


        public static int S33() 
        {
            var N = 3;

            var A = new int[1] { 1 };
            var B = new int[1] { 3 };
            
            var arr = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                arr[A[i]-1]++;
                arr[B[i]-1]++;
            }

            Array.Sort(arr);            

            var res = 0;

            for (var i = arr.Length - 1; i>=0; i--)
            {
                res += arr[i] * N;
                N--;
            }

            return res;
        }

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
