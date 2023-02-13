using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RomanToInteger
{
    public class Solution
    {
        public Dictionary<char, int> RomanToIntDict { get; set; } = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        /// <summary>
        /// Runtime 85 ms - Beats 42.79%
        /// Memory 47.7 MB - Beats 43.57%
        /// https://leetcode.com/problems/roman-to-integer/submissions/897417519/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var current = RomanToIntDict[s[i]];

                var j = i + 1;
                if (j < s.Length)
                {
                    var next = RomanToIntDict[s[j]];

                    if (current < next)
                    {
                        result -= RomanToIntDict[s[i]];
                        continue;
                    }
                    
                }
                result += RomanToIntDict[s[i]];
            }

            return result;
        }
    }
}
