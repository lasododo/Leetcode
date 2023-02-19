using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.InvertBinaryTree
{
    /// <summary>
    /// Runtime 81 ms - Beats 92.41%
    /// Memory 38.3 MB - Beats 22.86%
    /// https://leetcode.com/problems/invert-binary-tree/submissions/900032506/
    /// </summary>
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            var oldLeft = InvertTree(root.left);
            root.left = InvertTree(root.right);
            root.right = oldLeft;

            return root;
        }
    }
}
