using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var magdict = new Dictionary<char, int>();

            foreach (var c in magazine)
            {
                if (!magdict.ContainsKey(c))
                {
                    magdict[c] = 0;
                }

                magdict[c] += 1;
            }

            foreach (var c in ransomNote)
            {
                if (!magdict.ContainsKey(c) || magdict[c] <= 0)
                {
                    return false;
                }

                magdict[c] -= 1;
            }

            return true;
        }
    }
}
