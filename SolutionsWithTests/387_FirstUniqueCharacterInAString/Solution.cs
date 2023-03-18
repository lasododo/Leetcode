using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FirstUniqueCharacterInAString
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, List<int>>();
            var counter = 0;

            foreach (var c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = new();
                }

                dict[c].Add(counter);
                counter++;
            }

            var res = dict
                .Where(a => a.Value.Count == 1)
                .Select(a => a.Value.First())
                .OrderBy(a => a);

            if (res.Any() )
            {
                return res.First();
            }

            return -1;
        }
    }
}
