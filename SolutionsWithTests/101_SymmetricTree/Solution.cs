using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetric(root.left, root.right);
        }

        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            // check if one of them is not null
            if (left == null || right == null)
            {
                return false;
            }

            // check the vals
            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetric(left.left, right.left) && IsSymmetric(left.left, right.left);
        }
    }
}
