using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.Contest335.Medium_1
{

    public class Solution
    {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            if (root == null || k < 0)
            {
                return 0;
            }
                
            var que = new Queue<(TreeNode, int)>();
            var levels = new List<long>();

            que.Enqueue((root, 0));

            while (que.Count != 0)
            {
                var (node, level) = que.Dequeue();

                if (level >= levels.Count)
                {
                    levels.Add(0);
                }

                levels[level] += node.val;

                if (node.left != null)
                {
                    que.Enqueue((node.left, level + 1));
                }

                if (node.right != null)
                {
                    que.Enqueue((node.right, level + 1));
                }
            }

            if (levels.Count >= k)
            {
                return levels
                    .OrderByDescending(a => a)
                    .ToArray()[k - 1];
            }

            return -1;
        }
    }
}
