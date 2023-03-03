using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SortAnArray
{
    public class Solution
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length >= 2)
            {
                return MergeSort(nums, 0, nums.Length - 1);
            }

            return nums;
        }

        // Marge Sort :pepela:
        public int[] MergeSort(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                return new int[] { nums[startIndex] };
            }

            if (Math.Abs(startIndex - endIndex) < 2)
            {
                return new List<int>() { nums[startIndex], nums[endIndex] }.OrderBy(a => a).ToArray();
            }

            var mid = (startIndex + endIndex + 1) / 2;
            var left = MergeSort(nums, startIndex, mid);
            var right = MergeSort(nums, mid + 1, endIndex);

            var leftIndex = 0;
            var rightIndex = 0;
            var newArr = new int[left.Length + right.Length];
            var index = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    newArr[index] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    newArr[index] = right[rightIndex];
                    rightIndex++;
                }
                index++;
            }

            for (; leftIndex < left.Length; leftIndex++)
            {
                newArr[index] = left[leftIndex];
                index++;
            }

            for (; rightIndex < right.Length; rightIndex++)
            {
                newArr[index] = right[rightIndex];
                index++;
            }

            return newArr;
        }
    }
}
