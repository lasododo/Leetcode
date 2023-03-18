using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CheckCompletenessBinaryTree
{
    public class Solution
    {
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null) 
            {
                return false;
            }

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0) 
            {
                var node = q.Dequeue();

                if (node == null)
                {
                    break;
                }

                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }

            return !q.ToHashSet()
                .Where(a => a != null)
                .Any();
        }
    }
}
