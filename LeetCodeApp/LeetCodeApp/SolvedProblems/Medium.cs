﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeApp.SolvedProblems
{
    public class Medium
    {
        /// <summary>
        /// https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
        /// </summary>
        /// <param name="groupSizes"></param>
        /// <returns></returns>
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dict = new Dictionary<int, List<int>>();
            var list = new List<IList<int>>();
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

                if (item.Key == lenght)
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
            return list;
        }
    }

    /// <summary>
    /// https://leetcode.com/problems/subrectangle-queries/
    /// </summary>
    public class SubrectangleQueries
    {

        private int[][] _rectangle;

        public SubrectangleQueries(int[][] rectangle)
        {
            _rectangle = rectangle;

            
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    _rectangle[i][j] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return _rectangle[row][col];
        }
    }

}
