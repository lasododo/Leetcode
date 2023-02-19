using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SameTree
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree/submissions/900031261/
    /// </summary>
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            // check if one of them is not null
            if (p == null || q == null)
            {
                return false;
            }

            // check the vals
            if (p.val != q.val)
            {
                return false;
            }

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
