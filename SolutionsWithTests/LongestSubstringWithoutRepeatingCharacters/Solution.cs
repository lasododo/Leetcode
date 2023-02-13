using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Runtime 165 ms - Beats 23.62%
    /// Memory 48.8 MB - Beats 19%
    /// https://leetcode.com/submissions/detail/896823882/
    /// </summary>
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var sequence = new Dictionary<char, int>();
            var longest = 0;
            var seqStart = 0;
            for (var index = 0; index < s.Length; index++)
            {
                if (sequence.TryGetValue(s[index], out var foundAtIndex) && foundAtIndex >= seqStart)
                {
                    seqStart = foundAtIndex + 1;
                }

                sequence[s[index]] = index;

                if (longest < index - seqStart + 1)
                {
                    longest = index - seqStart + 1;
                }
            }

            return longest;
        }
    }
}
