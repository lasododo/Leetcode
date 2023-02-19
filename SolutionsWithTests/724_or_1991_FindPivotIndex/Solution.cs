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
            int sum = 0;
            int leftSum = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];
            }

            // 1 2 3 2 1
            // sum -> 9
            // 0 == 9 - 0 - 1
            // 1 == 9 - 1 - 2
            // 3 == 9 - 3 - 3

            for (int i = 0; i < nums.Length; ++i)
            {
                if (leftSum == sum - leftSum - nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
