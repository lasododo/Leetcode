using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveElement
{
    public class Solution
    {
        /// <summary>
        /// Runtime 132 ms - Beats 92.65%
        /// Memory 42.5 MB - Beats 62.6%
        /// https://leetcode.com/problems/remove-element/submissions/897971888/
        /// </summary>
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                }
            }
            return i;
        }
    }
}
