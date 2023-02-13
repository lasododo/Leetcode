using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MergeTwoSortedLists
{
    public class Solution
    {
        /// <summary>
        /// -> space complexity -> O(1), however it modifies the input.
        /// Runtime 88 ms - Beats 67.82%
        /// Memory 39.7 MB - Beats 61.5%
        /// https://leetcode.com/problems/merge-two-sorted-lists/submissions/897508854/
        /// </summary>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = null;
            ListNode current = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    if (current == null || result == null)
                    {
                        return list2;
                    }

                    current.next = list2;
                    return result;
                }

                if (list2 == null)
                {
                    if (current == null || result == null)
                    {
                        return list1;
                    }

                    current.next = list1;
                    return result;
                }

                if (list1.val <= list2.val)
                {
                    if (current == null)
                    {
                        current = list1;
                    }
                    else
                    {
                        current.next = new(list1.val);
                        current = current.next;
                    }

                    list1 = list1.next;
                }
                else
                {
                    if (current == null)
                    {
                        current = list2;
                    }
                    else
                    {
                        current.next = list2;
                        current = current.next;
                    }

                    list2 = list2.next;
                }

                if (result == null)
                {
                    result = current;
                }
            }

            return result;
        }

        /// <summary>
        /// -> Its fast, but it has O(n) space complexity.
        /// Runtime 85 ms - Beats 80.16%
        /// Memory 40.2 MB - Beats 5.2%
        /// https://leetcode.com/problems/merge-two-sorted-lists/submissions/897507567/
        /// </summary>
        public ListNode MergeTwoLists_First(ListNode list1, ListNode list2)
        {
            ListNode result = null;
            ListNode current = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    if (current == null || result == null)
                    {
                        return list2;
                    }

                    current.next = list2;
                    return result;
                }

                if (list2 == null)
                {
                    if (current == null || result == null)
                    {
                        return list1;
                    }

                    current.next = list1;
                    return result;
                }

                if (list1.val <= list2.val)
                {
                    if (current == null)
                    {
                        current = new(list1.val);
                    }
                    else
                    {
                        current.next = new(list1.val);
                        current = current.next;
                    }

                    list1 = list1.next;
                }
                else
                {
                    if (current == null)
                    {
                        current = new(list2.val);
                    }
                    else
                    {
                        current.next = new(list2.val);
                        current = current.next;
                    }

                    list2 = list2.next;
                }

                if (result == null)
                {
                    result = current;
                }
            }

            return result;
        }
    }
}
