using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidateBinarySearchTree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode root, long min, long max)
        {
            if (root.val <= min || root.val >= max)
            {
                return false;
            }

            var res = true;
            if (root.left != null)
            {
                res = res && IsValidBST(root.left, min, root.val);
            }

            if (root.right != null)
            {
                res = res && IsValidBST(root.right, root.val, max);
            }

            return res;
        }
    }
}
