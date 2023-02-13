using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PalindromeLinkedList
{
    public class Solution
    {
        /// <summary>
        /// Runtime 253 ms - Beats 65.54% 
        /// Memory 56.7 MB - Beats 50.89%
        /// https://leetcode.com/problems/palindrome-linked-list/submissions/897276664/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            var list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[(list.Count - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
