using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FindAllAnagramsInAString
{
    public class Solution
    {
        // O(n^2)
        public IList<int> FindAnagrams(string s, string p)
        {
            var list = new List<int>();

            var dict = MakeDictionaryFromChars(p, 0, p.Length);

            for (int i = 0; i < s.Length; i++)
            {
                if ((s.Length - i) < p.Length)
                {
                    return list;
                }

                var innerDict = MakeDictionaryFromChars(s, i, i + p.Length);
                if (AreDictsEqual(dict, innerDict))
                {
                    list.Add(i);
                }

            }

            return list;
        }

        // O(n)
        private static bool AreDictsEqual(Dictionary<char, int> left, Dictionary<char, int> right)
        {
            if (left.Keys.Count != right.Keys.Count)
            {
                return false;
            }

            if (!left.Keys.OrderBy(a => a).SequenceEqual(right.Keys.OrderBy(a => a)))
            {
                return false;
            }

            foreach (var (k, v) in left)
            {
                if (left[k] != right[k])
                {
                    return false;
                }
            }

            return true;
        }

        private static new Dictionary<char, int> MakeDictionaryFromChars(string p, int start, int end)
        {
            var dict = new Dictionary<char, int>();

            for (; start < end; start++)
            {
                var c = p[start];
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 0;
                }

                dict[c] += 1;
            }

            return dict;
        }
    }
}
