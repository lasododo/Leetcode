using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LowestCommonAncestorBinarySearchTree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
            {
                return null;
            }

            if (p.val < q.val)
            {
                return IterateBST(root, p, q);
            }

            return IterateBST(root, q, p);
        }

        public TreeNode IterateBST(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            // 2 <= 1 && 2 >= 2
            if (root.val <= q.val && root.val >= p.val)
            {
                return root;
            }

            if (root.val > q.val)
            {
                return IterateBST(root.left, p, q);
            }

            return IterateBST(root.right, p, q);
        }
    }
}
