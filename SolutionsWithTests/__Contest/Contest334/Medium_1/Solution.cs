using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Medium_1
{

    public class Solution
    {
        public int[] DivisibilityArray(string word, int m)
        {
            long currentWord = 0;
            var res = new int[word.Length];

            var index = 0;
            foreach (var c in word)
            {
                var digit = c - '0';
                currentWord = (currentWord * 10 + digit) % m;
                res[index] = (currentWord == 0 ? 1 : 0);
                index++;
            }

            return res;
        }
    }

    public class SolutionOld
    {
        public int[] DivisibilityArray(string word, int m)
        {
            var currentWord = string.Empty;
            var res = new int[word.Length];
            var divider = new BigInteger(m);
            var dict = new Dictionary<string, (string, int)>();

            var index = 0;
            foreach (var c in word)
            {
                currentWord += c;

                if (dict.TryGetValue(currentWord, out (string, int) value)) 
                {
                    res[index] = value.Item2;
                    currentWord = value.Item1;
                }
                else
                {
                    var bi = BigInteger.Parse(currentWord);
                    res[index] = (bi % divider == 0 ? 1 : 0);
                    dict[currentWord] = ((bi % divider).ToString(), res[index]);
                }

                index++;
            }

            return res;
        }
    }
}
