using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.AddTwoNumbers
{
    public class Solution
    {
        /// <summary>
        /// Runtime 97 ms - Beats 75.90% 
        /// Memory 49.3 MB - Beats 37.24%
        /// https://leetcode.com/submissions/detail/896797591/
        /// </summary>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var solutionFirst = new ListNode();

            ListNode prev = null;
            var current = solutionFirst;
            var currentL1 = l1;
            var currentL2 = l2;

            while (currentL1 != null || currentL2 != null)
            {
                if (currentL1 != null)
                {
                    current.val += currentL1.val;
                    currentL1 = currentL1.next;
                }

                if (currentL2 != null)
                {
                    current.val += currentL2.val;
                    currentL2 = currentL2.next;
                }

                current.next = new(current.val / 10);
                current.val %= 10;

                prev = current;
                current = current.next;
            }

            if (prev != null && current.val == 0)
            {
                prev.next = null;
            }

            return solutionFirst;
        }
    }
}
