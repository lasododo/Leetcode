using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BinaryTreePostorderTraversal
{
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            PostOrderTraversal(root, result);

            return result;
        }

        public void PostOrderTraversal(TreeNode root, List<int> nodes)
        {
            if (root.left != null)
            {
                PostOrderTraversal(root.left, nodes);
            }

            if (root.right != null)
            {
                PostOrderTraversal(root.right, nodes);
            }

            nodes.Add(root.val);
        }
    }
}
