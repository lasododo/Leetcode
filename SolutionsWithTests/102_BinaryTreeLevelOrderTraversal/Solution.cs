using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BinaryTreeLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var queueLevelCount = queue.Count;
            var currentLevel = new List<int>();

            while(queue.Count > 0)
            {
                queueLevelCount--;
                var current = queue.Dequeue();
                currentLevel.Add(current.val);

                if (current.left != null) { queue.Enqueue(current.left); }
                if (current.right != null) { queue.Enqueue(current.right); }

                if (queueLevelCount == 0)
                {
                    result.Add(currentLevel);
                    currentLevel = new();
                    queueLevelCount = queue.Count;
                }
            }

            return result;
        }
    }
}
