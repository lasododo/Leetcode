using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BackspaceStringCompare
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }

                    continue;
                }
                stack.Push(s[i]);
            }

            var s1 = stack.AsEnumerable().Reverse();

            stack = new Stack<char>();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }

                    continue;
                }
                stack.Push(t[i]);
            }

            var s2 = stack.AsEnumerable().Reverse();
            return s1.SequenceEqual(s2);
        }
    }
}
