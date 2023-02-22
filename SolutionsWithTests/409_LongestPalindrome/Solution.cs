using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 0;
                }

                dict[c] += 1;
            }
        }
    }
}
