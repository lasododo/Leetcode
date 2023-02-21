using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LinkedListCycleII
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head, Dictionary<ListNode, ListNode>? indexDict = null)
        {
            if (head == null)
            {
                return head;
            }

            if (indexDict == null)
            {
                indexDict = new Dictionary<ListNode, ListNode>();
            }

            if (indexDict.ContainsKey(head))
            {
                return indexDict[head];
            }

            indexDict[head] = head;

            return DetectCycle(head.next, indexDict);
        }
    }
}
