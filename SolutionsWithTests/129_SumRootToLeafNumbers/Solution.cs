using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SumRootToLeafNumbers
{
    public class Solution
    {
        public int SumNumbers(TreeNode root, int sum = 0)
        {
            if (root == null)
            {
                return sum;
            }

            if (root.left == null && root.right == null)
            {
                return sum * 10 + root.val;
            }

            int nodeSum = 0;
            if (root.left != null)
            {
                nodeSum += SumNumbers(root.left, sum * 10 + root.val);
            }
            
            if (root.right != null)
            {
                nodeSum += SumNumbers(root.right, sum * 10 + root.val);
            }

            return nodeSum;
        }
    }
}
