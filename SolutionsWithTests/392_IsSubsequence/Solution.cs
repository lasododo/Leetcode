using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.IsSubsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length || s.Length == 0)
            {
                return s.Length == 0;
            }

            var sIndex = 0;
            var tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }

            return sIndex == s.Length;

        }
    }
}
