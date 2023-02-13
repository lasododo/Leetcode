using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ReverseLinkedList
{
    public class Solution
    {
        /// <summary>
        /// Runtime 89 ms - Beats 57.21%
        /// Memory 39.1 MB - Beats 28.9%
        /// https://leetcode.com/problems/reverse-linked-list/submissions/897358898/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }

        /// <summary>
        /// Runtime 94 ms - Beats 34.74%
        /// Memory 39.6 MB - Beats 8.37%
        /// https://leetcode.com/problems/reverse-linked-list/submissions/897356113/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseListSlow(ListNode head, ListNode? prev = null)
        {
            if (head == null)
            {
                return null;
            }

            var newHead = new ListNode(head.val);
            newHead.next = prev;

            if (head.next == null)
            {
                return newHead;
            }

            return ReverseListSlow(head.next, newHead);
        }
    }
}
