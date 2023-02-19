using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ClimbingStairs
{
    /// <summary>
    /// Runtime 17 ms - Beats 96.42%
    /// Memory 26.7 MB - Beats 31.8%
    /// https://leetcode.com/problems/climbing-stairs/submissions/900016200/
    /// </summary>
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n < 4)
            {
                return n;
            }

            var left = 2;
            var right = 3;
            n -= 3;

            while (n > 0)
            {
                var newLeft = right;
                right = left + right;
                left = newLeft;
                n--;
            }

            return right;
        }
    }
}
