using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LengthOfLastWord
{
    /// <summary>
    /// Runtime 71 ms - Beats 34.66%
    /// Memory 36.2 MB - Beats 77.96%
    /// https://leetcode.com/problems/length-of-last-word/submissions/899964173/
    /// </summary>
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            bool wasFound = false;
            var firstCharIndex = s.Length;
            var lastCharIndex = s.Length;

            while(firstCharIndex > 0)
            {
                firstCharIndex--;

                var charIsWhiteSpace = char.IsWhiteSpace(s[firstCharIndex]);

                if ((charIsWhiteSpace && !wasFound) || (!charIsWhiteSpace && wasFound))
                {
                    continue;
                }

                if (wasFound)
                {
                    return lastCharIndex - firstCharIndex;
                }

                lastCharIndex = firstCharIndex;
                wasFound = true;
            }

            if (wasFound)
            {
                return lastCharIndex - firstCharIndex + (firstCharIndex == 0 ? 1 : 0);
            }

            return 0;
        }
    }
}
