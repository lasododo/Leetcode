using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PathSum
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            var q = new Queue<(TreeNode, int)>();
            q.Enqueue((root, 0));

            while (q.Count > 0)
            {
                var (node, sum) = q.Dequeue();

                sum += node.val;

                if (IsLeafNode(node))
                {
                    if (sum == targetSum)
                    {
                        return true;
                    }
                    continue;
                }

                if (node.left != null)
                {
                    q.Enqueue((node.left, sum));
                }

                if (node.right != null)
                {
                    q.Enqueue((node.right, sum));
                }
            }

            return false;
        }

        private static bool IsLeafNode(TreeNode node)
        {
            if (node == null) 
                return false;

            return node.left == null && node.right == null;
        }
    }
}
