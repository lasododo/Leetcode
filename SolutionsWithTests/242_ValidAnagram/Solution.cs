using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }    

            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 0;
                }

                dict[c] += 1;
            }

            foreach (var c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    return false;
                }

                dict[c] -= 1;
            }

            return !dict.Values
                .Where(a => a != 0)
                .Any();
        }
    }
}
