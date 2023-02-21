using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MiddleOfTheLinkedList
{
    public class Solution
    {
        // could be done using bool only :)
        public ListNode MiddleNode(ListNode head)
        {
            var mid = head;
            var count = 1;

            while (head != null)
            {
                if (count % 2 == 0)
                {
                    mid = mid.next;
                }

                head = head.next;
                count++;
            }

            return mid;
        }
    }
}
