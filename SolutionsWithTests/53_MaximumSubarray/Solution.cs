using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MaximumSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var max = -10000;
            var currentMax = -10000;

            foreach (var n in nums)
            {
                max = Math.Max(max + n, n);
                currentMax = Math.Max(currentMax, max);
            }

            return currentMax;
        }
    }
}
