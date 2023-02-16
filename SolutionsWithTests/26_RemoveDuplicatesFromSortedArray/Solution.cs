using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        /// <summary>
        /// Runtime 150 ms - Beats 71.63%
        /// Memory 46.1 MB - Beats 44.94%
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/897715767/
        /// </summary>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums == null ? 0 : nums.Length;
            }

            var currentIndex = 1;
            var swapIndex = 1;

            var current = nums[currentIndex];
            var prev = nums[currentIndex - 1];

            while (swapIndex < nums.Length)
            {
                if (nums[swapIndex] > prev)
                {
                    nums[currentIndex] = nums[swapIndex];
                    nums[swapIndex] = current;
                    currentIndex += 1;

                    if (currentIndex >= nums.Length)
                    {
                        break;
                    }

                    current = nums[currentIndex];
                    prev = nums[currentIndex - 1];
                }

                swapIndex += 1;
            }

            return currentIndex;
        }
    }
}
