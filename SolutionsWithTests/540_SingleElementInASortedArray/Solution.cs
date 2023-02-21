using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SingleElementInASortedArray
{
    public class Solution
    {
        // Time Complexity: O(logn)
        // Space Complexity O(1)
        public int SingleNonDuplicate(int[] nums)
        {
            var left = 0; 
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = (left + right) / 2 ;
                mid -= mid % 2;

                if (nums[mid] != nums[mid + 1])
                {
                    right = mid;
                }

                else
                {
                    left = mid + 2;
                }
            }
            return nums[left];
        }

        // Time Complexity: O(logn)
        // Space Complexity O(logn) - Theoretically ... Practically -> Tail Recurrsion gets optimalized 
        public int SingleNonDuplicateLogn(int[] nums)
        {
            if (nums == null || nums.Length % 2 == 0)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            return NonDuplicateSearch(nums, 0, nums.Length - 1);
        }

        private int NonDuplicateSearch(int[] nums, int minIndex, int maxIndex)
        {
            if (Math.Abs(minIndex - maxIndex) < 2)
            {
                return PickTheOddOneOut(nums, minIndex, maxIndex);
            }

            var midIndex = (maxIndex + minIndex) / 2 ;
            var midIndexFlop = midIndex % 2;

            var duplicateOnLeft = nums[midIndex] == nums[midIndex - 1];
            var duplicateOnRight = nums[midIndex] == nums[midIndex + 1];

            // go left
            if (duplicateOnLeft)
            {
                if (midIndexFlop == 0)
                {
                    return NonDuplicateSearch(nums, minIndex, midIndex);
                }

                return NonDuplicateSearch(nums, midIndex, maxIndex);
            }

            // go right
            if (duplicateOnRight)
            {
                if (midIndexFlop == 0)
                {
                    return NonDuplicateSearch(nums, midIndex, maxIndex);
                }

                return NonDuplicateSearch(nums, minIndex, midIndex);
            }

            return nums[midIndex];
        }

        private int PickTheOddOneOut(int[] nums, int min, int max)
        {
            if (min == max)
            {
                return nums[min];
            }

            var mid = (max - min) / 2;

            if (mid == min)
            {
                if (mid != 0 && nums[min] == nums[mid - 1])
                {
                    return nums[max];
                }

                return nums[min];
            }

            if (max != nums.Length - 1 && nums[max] == nums[max + 1])
            {
                return nums[min];
            }

            return nums[max];
        }
    }
}
