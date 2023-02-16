using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.AddBinary
{
    public class Solution
    {
        /// <summary>
        /// Runtime 74 ms - Beats 94.19%
        /// Memory 38.5 MB - Beats 74.15%
        /// https://leetcode.com/problems/add-binary/submissions/897731107/
        /// </summary>
        public string AddBinary(string a, string b)
        {
            var result = new List<char>();
            var movedForward = 0;
            var index = 0;
            var current = 0;

            while (index < a.Length || index < b.Length)
            {
                current = movedForward;
                current += index < a.Length ? (a[(a.Length - 1) - index] == '1' ? 1 : 0) : 0;
                current += index < b.Length ? (b[(b.Length - 1) - index] == '1' ? 1 : 0) : 0;
                result.Add(current % 2 == 0 ? '0' : '1');
                movedForward = current >= 2 ? 1 : 0;
                index++;
            }

            if (movedForward != 0)
            {
                result.Add('1');
            }

            return new string(result.Reverse<char>().ToArray());
        }
    }
}
