using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.DecodeString
{
    public class Solution
    {
        public string DecodeString(string s)
        {
            var currentNum = 0;
            var res = string.Empty;
            var i = 0;
            while(i < s.Length)
            {
                if (int.TryParse(s[i].ToString(), out var number))
                {
                    currentNum *= 10;
                    currentNum += number;
                }
                else
                {
                    var currStr = string.Empty;
                    while(s[i] != ']')
                    {
                        if (s[i] != '[')
                        {
                            currStr += s[i];
                            continue;
                        }
                        i++;
                    }
                    res = string.Join(res, string.Concat(Enumerable.Repeat(currStr, currentNum)));
                    currentNum = 0;
                }
                i++;
            }

            return res;
        }
    }
}
