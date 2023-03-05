using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CountSubarraysWithFixedBounds
{
    public class Solution
    {
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long count = 0;
            int brokenIndex = -1;
            int oldMinKIndex = -1;
            int oldMaxKIndex = -1;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] < minK || nums[i] > maxK)
                {
                    brokenIndex = i;
                }

                if (nums[i] == minK)
                {
                    oldMinKIndex = i;
                }

                if (nums[i] == maxK)
                {
                    oldMaxKIndex = i;
                }

                count += Math.Max(0, Math.Min(oldMinKIndex, oldMaxKIndex) - brokenIndex);
            }

            return count;
        }
    }
}
