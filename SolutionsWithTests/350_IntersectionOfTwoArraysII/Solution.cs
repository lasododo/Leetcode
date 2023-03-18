using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.IntersectionOfTwoArraysII
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();

            foreach (int i in nums1)
            {
                if (!dict.ContainsKey(i))
                {
                    dict[i] = 0;
                }

                dict[i]++;
            }

            var ret = new List<int>();

            foreach (var item in nums2)
            {
                if (!dict.ContainsKey(item))
                {
                    continue;
                }

                if (dict[item] <= 0)
                {
                    continue;
                }

                ret.Add(item);
                dict[item]--;
            }

            return ret.ToArray();
        }
    }
}
