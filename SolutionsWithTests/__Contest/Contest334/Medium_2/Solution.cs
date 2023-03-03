using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Medium_2
{

    public class Solution
    {
        public int MaxNumOfMarkedIndices(int[] nums)
        {
            int n = nums.Length;
            Array.Sort(nums);
            var marked = new HashSet<int>();
            var i = 0;

            for (int j = (n + 1) / 2; j < n; j++)
            {
                if (2 * nums[i] <= nums[j] && !marked.Contains(j))
                {
                    i++;
                }
            }

            return i * 2;
        }
    }
}
