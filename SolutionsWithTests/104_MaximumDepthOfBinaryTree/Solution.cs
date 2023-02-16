using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MaximumDepthOfBinaryTree
{
    public class Solution
    {
        /// <summary>
        /// Runtime 78 ms - Beats 99.5%
        /// Memory 39.6 MB - Beats 62.60%
        /// https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/898961577/
        /// </summary>
        public int MaxDepth(TreeNode root, int depth = 0)
        {
            if (root == null)
            {
                return depth;
            }

            return Math.Max(MaxDepth(root.left, depth + 1), MaxDepth(root.right, depth + 1));
        }
    }
}
