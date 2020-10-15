using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeApp.SolvedProblems
{
    public class Hard
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double med = 0;

            var l1 = nums1.Length;

            var l2 = nums2.Length;

            var lS = l1 + l2;

            if (l1 > 0 && l2 > 0)
            {
                var nums3 = new int[lS];

                Array.Copy(nums1, nums3, l1);
                Array.Copy(nums2, 0, nums3, l1, l2);

                Array.Sort(nums3);



                if (lS % 2 == 0)
                {
                    var a1 = nums3[lS / 2 - 1];
                    var a2 = nums3[lS / 2];

                    med = (a1 + a2) / 2.0;
                }
                else
                {
                    med = nums3[(lS - 1) / 2];
                }
            }
            else if (l1 > 0 && l2 == 0)
            {
                Array.Sort(nums1);

                if (l1 % 2 == 0)
                {
                    var a1 = nums1[l1 / 2 - 1];
                    var a2 = nums1[l1 / 2];

                    med = (a1 + a2) / 2.0;
                }
                else
                {
                    med = nums1[(l1 - 1) / 2];
                }
            }
            else if (l1 == 0 && l2 > 0)
            {
                Array.Sort(nums2);

                if (l2 % 2 == 0)
                {
                    var a1 = nums2[l2 / 2 - 1];
                    var a2 = nums2[l2 / 2];

                    med = (a1 + a2) / 2.0;
                }
                else
                {
                    med = nums2[(l2 - 1) / 2];
                }
            }

            return med;
        }
    }
}
