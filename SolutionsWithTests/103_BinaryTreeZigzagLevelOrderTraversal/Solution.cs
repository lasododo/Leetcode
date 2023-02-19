using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BinaryTreeZigzagLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            var nodeList = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentLevelCount = 1;
            var currentIndex = 0;
            var currentLevel = new List<int>();
            var enqueueLeft = true;

            while (queue.Count > 0)
            {
                var top = queue.Dequeue();

                currentLevel.Add(top.val);

                if (enqueueLeft)
                {
                    TryEnqueue(queue, top.left);
                    TryEnqueue(queue, top.right);
                }
                else
                {
                    TryEnqueue(queue, top.right);
                    TryEnqueue(queue, top.left);
                }

                currentIndex += 1;

                if (currentIndex == currentLevelCount)
                {
                    nodeList.Add(currentLevel);
                    currentLevel = new();
                    currentLevelCount = queue.Count;
                    currentIndex = 0;
                    queue = new Queue<TreeNode>(queue.Reverse()); ;
                    enqueueLeft = !enqueueLeft;
                }
            }

            return nodeList;
        }

        private static void TryEnqueue(Queue<TreeNode> queue, TreeNode top)
        {
            if (top != null)
            {
                queue.Enqueue(top);
            }
        }
    }
}
