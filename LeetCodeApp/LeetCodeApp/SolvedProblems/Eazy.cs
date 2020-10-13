using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeApp.SolvedProblems
{
    public class Eazy
    {
        /// <summary>
        /// https://leetcode.com/problems/running-sum-of-1d-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RunningSum(int[] nums)
        {            
            var arr2 = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                var res = nums[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    res += nums[j];
                }

                arr2[i] = res;
            }

            return arr2;
        }

        /// <summary>
        /// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var arr = new bool[candies.Length];

            var max = candies[0];

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    arr[i] = true;
                }
                else
                {
                    arr[i] = false;
                }

            }

            return arr;
        }

        /// <summary>
        /// https://leetcode.com/problems/shuffle-the-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Shuffle(int[] nums, int n)
        {
            var arr = new int[nums.Length];

            for (int i = 0, j = 0; i < nums.Length; i += 2, j++)
            {
                arr[i] = nums[j];
            }

            for (int i = 1, j = n; i < nums.Length; i += 2, j++)
            {
                arr[i] = nums[j];
            }

            return arr;
        }

        /// <summary>
        /// https://leetcode.com/problems/number-of-good-pairs/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int NumIdenticalPairs(int[] nums)
        {
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// https://leetcode.com/problems/defanging-an-ip-address/
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public string DefangIPaddr(string address)
        {
            var res = new char[address.Length + 6];

            var count = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    res[count] = '[';
                    res[count + 1] = '.';
                    res[count + 2] = ']';
                    count += 3;
                }
                else
                {
                    res[count] = address[i];
                    count++;
                }
            }

            return new string(res);
        }

        /// <summary>
        /// https://leetcode.com/problems/jewels-and-stones/
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string J, string S)
        {
            var count = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (J.Contains(S[i]))
                {
                    count++;
                }
            }


            return count;
        }

        /// <summary>
        /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int NumberOfSteps(int num)
        {
            var count = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
                count++;
            }

            return count;
        }


    }
}
