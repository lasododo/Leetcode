using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BinaryTreePreorderTraversal
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            PreorderTraversal(root, result);

            return result;
        }

        public void PreorderTraversal(TreeNode root, List<int> nodes)
        {
            nodes.Add(root.val);

            if (root.left != null)
            {
                PreorderTraversal(root.left, nodes);
            }

            if (root.right != null)
            {
                PreorderTraversal(root.right, nodes);
            }
        }
    }
}
