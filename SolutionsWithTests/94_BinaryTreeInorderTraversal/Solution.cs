using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BinaryTreeInorderTraversal
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            InorderTraversal(root, result);

            return result;
        }

        public void InorderTraversal(TreeNode root, List<int> nodes)
        {
            if (root.left != null)
            {
                InorderTraversal(root.left, nodes);
            }

            nodes.Add(root.val);

            if (root.right != null)
            {
                InorderTraversal(root.right, nodes);
            }
        }
    }
}
