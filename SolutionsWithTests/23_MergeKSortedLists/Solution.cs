using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MergeKSortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var priorityQueue = new PriorityQueue<ListNode, int>();

            foreach (var linkedList in lists)
            {
                var head = linkedList;
                while (head != null)
                {
                    priorityQueue.Enqueue(head, head.val);
                    head = head.next;
                }
            }

            var arr = new List<ListNode>();
            while (priorityQueue.Count > 0)
            {
                var elem = priorityQueue.Dequeue();

                if (arr.Count > 0)
                {
                    arr.Last().next = elem;
                }

                arr.Add(elem);
            }

            if (arr.Count > 0)
            {
                arr.Last().next = null;
            }
            
            return arr.FirstOrDefault();
        }
    }
}
