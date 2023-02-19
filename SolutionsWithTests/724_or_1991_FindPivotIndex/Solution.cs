using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FindPivotIndex
{
    public class Solution
    {
        public int FindMiddleIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            var leftArr = new int[nums.Length];
            var rightArr = new int[nums.Length];
            var len = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    leftArr[0] = nums[0];
                    rightArr[len] = nums[len];
                    continue;
                }
                
                leftArr[i] = nums[i] + leftArr[i - 1];
                rightArr[len - i] = nums[len - i] + rightArr[(len - i) + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftArr[i] == rightArr[len - i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
