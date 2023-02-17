using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PlusOne
{
    /// <summary>
    /// Runtime 131 ms - Beats 92.22%
    /// Memory 42.4 MB - Beats 30.12%
    /// https://leetcode.com/problems/plus-one/submissions/899973018/
    /// </summary>
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null)
            {
                return new int[] { 0 };
            }

            var list = new List<int>();
            var toAdd = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                list.Add((digits[i] + toAdd) % 10);
                toAdd = (digits[i] + toAdd) / 10;
            }

            if (toAdd != 0)
            {
                list.Add(toAdd);
            }

            return list.Reverse<int>().ToArray();
        }
    }
}
