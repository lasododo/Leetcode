using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Easy_Excerice_1
{
    public class Solution
    {
        public int[] LeftRigthDifference(int[] nums)
        {
            var resLeft = new int[nums.Length];
            resLeft[0] = nums[0];
            var resRight = new int[nums.Length];
            resRight[nums.Length - 1] = nums[nums.Length - 1];
            var res = new int[nums.Length];
            var reverseIndex = nums.Length - 1;

            for (int i = 1; i < nums.Length; i++)
            {
                resLeft[i] = resLeft[i - 1] + nums[i];
                resRight[reverseIndex - i] = resRight[reverseIndex - i + 1] + nums[reverseIndex - i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = Math.Abs(resLeft[i] - resRight[i]);
            }

            return res;
        }
    }
}
