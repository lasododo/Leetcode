using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            var res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[(i + k) % nums.Length] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = res[i];
            }
        }
    }
}
