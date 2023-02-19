using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RunningSumOf1dArray
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
