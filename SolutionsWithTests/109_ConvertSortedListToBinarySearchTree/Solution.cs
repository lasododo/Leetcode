using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ConvertSortedListToBinarySearchTree
{
    public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var newList = new List<TreeNode>();

            while (head != null)
            {
                newList.Add(new(head.val));
                head = head.next;
            }

            var rootIndex = (newList.Count) / 2;

            SetChildrenForNode(newList, rootIndex, 0, newList.Count - 1);

            return newList[rootIndex]; ;
        }

        /// <summary>
        /// 
        ///    1, 2, 3, 4, 5, 6, 7
        ///     
        /// 
        ///             3
        ///        1         5
        ///     0    2    4     6
        /// 
        /// 
        /// 
        ///    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
        ///    
        ///                  10 / 2
        ///                     5
        ///          2                     8
        ///      1       3           6          10 
        ///  0              4           7           11
        /// 
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// 
        /// -10, -3, 0, 5, 9, 10
        private TreeNode SetChildrenForNode(List<TreeNode> nodeList, int currentNode, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var mid = (left + right) / 2;
            var node = nodeList[mid];
            node.left = SetChildrenForNode(nodeList, currentNode, left, mid - 1);
            node.right = SetChildrenForNode(nodeList, currentNode, mid + 1, right);
            return node;
        }
    }
}
