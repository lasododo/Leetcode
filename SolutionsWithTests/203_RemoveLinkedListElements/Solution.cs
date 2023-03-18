using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveLinkedListElements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            var res = RemoveElements(head.next, val);

            if (head.val != val)
            {
                head.next = res;
                res = head;
            }

            return res;
        }
    }
}
