using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MinimumDistanceBetweenBSTNodes
{
    /// <summary>
    /// Runtime 88 ms - Beats 67.31%
    /// Memory 38.2 MB - Beats 38.46%
    /// https://leetcode.com/problems/minimum-distance-between-bst-nodes/submissions/899762566/
    /// </summary>
    public class Solution
    {
        public static int MaxDistance { get; } = int.MaxValue;
        private readonly List<int> AllNumbers = new();

        public int MinDiffInBST(TreeNode root)
        {
            Traverse(root);
            var min = MaxDistance;

            for (int i = AllNumbers.Count - 1; i > 0; i--)
            {
                min = Math.Min(Math.Abs(AllNumbers[i] - AllNumbers[i - 1]), min);
            }

            return min;
        }

        private void Traverse(TreeNode root)
        {
            if (root != null)
            {
                Traverse(root.left);
                AllNumbers.Add(root.val);
                Traverse(root.right);
            }
        }
    }

    /// <summary>
    /// Runtime 93 ms - Beats 36.54% 
    /// Memory 38.4 MB - Beats 17.31%
    /// https://leetcode.com/problems/minimum-distance-between-bst-nodes/submissions/899759205/
    /// </summary>
    public class SolutionFirst
    {
        public static int MaxDistance { get; } = int.MaxValue;

        public int MinDiffInBST(TreeNode root, int min = int.MaxValue, int max = int.MaxValue)
        {
            if (root == null)
            {
                return MaxDistance;
            }

            var distances = new List<int>()
            {
                Math.Abs(root.val - max),
                Math.Abs(root.val - min),
            };

            if (root.left != null)
            {
                distances.Add(Math.Abs(root.left.val - root.val));
                distances.Add(MinDiffInBST(root.left, min, root.val));
            }

            if (root.right != null)
            {
                distances.Add(Math.Abs(root.right.val - root.val));
                distances.Add(MinDiffInBST(root.right, root.val, max));
            }

            return distances.Min();

        }
    }
}
