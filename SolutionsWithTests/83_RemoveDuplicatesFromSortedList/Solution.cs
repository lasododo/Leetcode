using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveDuplicatesFromSortedList
{
    /// <summary>
    /// Runtime 89 ms - Beats 72.24%
    /// Memory 39.8 MB - Beats 57.94%
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/submissions/900021058/
    /// </summary>
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var originalHead = head;
            var prev = head;

            while (head != null)
            {
                if (head.val != prev.val)
                {
                    prev.next = head;
                    prev = head;
                }

                head = head.next;
            }

            if (prev != null)
            {
                prev.next = null;
            }

            return originalHead;
        }
    }
}
