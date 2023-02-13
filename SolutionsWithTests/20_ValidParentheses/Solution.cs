﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0)
                {
                    return false;
                }

                var top = stack.Pop();

                if (c == ')' && top != '(')
                {
                    return false;
                }

                if (c == ']' && top != '[')
                {
                    return false;
                }

                if (c == '}' && top != '{')
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
