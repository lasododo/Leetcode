using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.TopKFrequentWords
{
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }

                dict[word]++;
            }

            return dict
                .OrderByDescending(x => x.Value)
                .ThenBy(a => a.Key)
                .Select(a => a.Key)
                .Take(k)
                .ToList();
        }
    }

}
