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

            var nums = new int[] { 1, 1, 2, 3 };

            var lenght = 0;

            for (int i = 0; i < nums.Length; i+=2)
            {
                lenght += nums[i];
            }

            var arr = new int[lenght];

            var count = 0;

            for (int i = 0; i < nums.Length; i+=2)
            {
                var freq = nums[i];
                var val = nums[i + 1];

                

                for (var j=count; j < count+freq; j++)
                {
                    arr[j] = val;

                }
                count += freq;
            }
            
            Console.ReadKey();
        }


        
        
       

    }
}
