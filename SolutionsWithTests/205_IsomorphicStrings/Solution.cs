using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.IsomorphicStrings
{
    /// <summary>
    /// Runtime 69 ms - Beats 98.29%
    /// Memory 39.4 MB - Beats 78.14%
    /// https://leetcode.com/problems/isomorphic-strings/submissions/901148453/
    /// </summary>
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return s.Length == 0;
            }

            var replaceDictionary = new Dictionary<char, char>();
            var replaceDictionary2 = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!replaceDictionary.ContainsKey(s[i]))
                {
                    replaceDictionary[s[i]] = t[i];
                }

                if (replaceDictionary[s[i]] != t[i])
                {
                    return false;
                }

                if (!replaceDictionary2.ContainsKey(t[i]))
                {
                    replaceDictionary2[t[i]] = s[i];
                }
                
                if (replaceDictionary2[t[i]] != s[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
