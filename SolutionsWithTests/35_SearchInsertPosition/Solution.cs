using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SearchInsertPosition
{
    public class Solution
    {
        /// <summary>
        /// Runtime 88 ms - Beats 73.76%
        /// Memory 39.6 MB - Beats 7.91%
        /// https://leetcode.com/problems/search-insert-position/submissions/898766355/
        /// </summary>
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
            {
                return -1;
            }

            if (nums.Length == 0)
            {
                return 0;
            }

            return SearchInsert(nums, target, 0, nums.Length - 1);
        }

        private int SearchInsert(int[] nums, int target, int lowerIndex, int upperIndex)
        {
            if (nums[lowerIndex] == target)
            {
                return lowerIndex;
            }

            if (nums[upperIndex] == target)
            {
                return upperIndex;
            }

            if (upperIndex - lowerIndex < 2)
            {
                if (nums[upperIndex] < target)
                {
                    return upperIndex + 1;
                }

                if (nums[upperIndex] > target && nums[lowerIndex] < target)
                {
                    return upperIndex;
                }

                return lowerIndex;
            }

            var midIndex = (lowerIndex + upperIndex) / 2;

            if (nums[midIndex] < target) 
            {
                return SearchInsert(nums, target, midIndex, upperIndex);
            }

            return SearchInsert(nums, target, lowerIndex, midIndex);
        }
    }
}
