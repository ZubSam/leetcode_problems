using LeetCodeApp.SolvedProblems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };

            var dict = new Dictionary<int, List<int>>();
            var list = new List<int[]>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (dict.ContainsKey(groupSizes[i]))
                {
                    dict[groupSizes[i]].Add(i);
                }
                else
                {
                    dict.Add(groupSizes[i], new List<int>() { i });
                }
            }

            for (int i = 0; i < dict.Count; i++)
            {
                var item = dict.ElementAt(i);

                var lenght = item.Value.Count;

                if(item.Key == lenght)
                {
                    var arr1 = new int[lenght];

                    for (int j = 0; j < lenght; j++)
                    {
                        arr1[j] = item.Value[j];
                    }
                    list.Add(arr1);
                }
                else
                {
                    var r = lenght / item.Key;
                    var count = 0;

                    for (int j = 0; j < r; j++)
                    {
                        var arr1 = new int[item.Key];

                        for (int k = 0; k < item.Key; k++)
                        {
                            arr1[k] = item.Value[k + count];
                        }

                        count += item.Key;

                        list.Add(arr1);
                    }
                }

                
            }

            Console.ReadKey();
        }


        
        
       

    }
}
