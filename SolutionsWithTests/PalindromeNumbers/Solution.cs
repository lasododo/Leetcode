using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PalindromeNumbers
{
    public class Solution
    {
        /// <summary>
        /// Runtime 55 ms - Beats 53.91% 
        /// Memory 29.5 MB - Beats 71.61%
        /// LINK: https://leetcode.com/problems/palindrome-number/submissions/897268457/
        /// </summary>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var originalNumber = x;
            var reversedNumber = 0;

            while (x > 0)
            {
                reversedNumber = (reversedNumber * 10) + (x % 10);
                x /= 10;
            }

            return reversedNumber == originalNumber;
        }
    }
}
