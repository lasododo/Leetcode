using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LongestCommonPrefix
{
    public class Solution
    {
        /// <summary>
        /// Runtime 98 ms - Beats 78.46% 
        /// Memory 39.4 MB - Beats 80.31%
        /// https://leetcode.com/problems/longest-common-prefix/submissions/897424813/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;

            var index = 0;

            while (true)
            {
                char additionalChar = '.';

                foreach (var item in strs)
                {
                    if (index >= item.Length)
                    {
                        return result;
                    }

                    if (additionalChar == '.')
                    {
                        additionalChar = item[index];
                        continue;
                    }

                    if (additionalChar != item[index])
                    {
                        return result;
                    }
                }

                result += additionalChar;
                index += 1;
            }
        }
    }
}
