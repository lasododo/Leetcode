using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.TwoSumIVInputBST
{
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }

            var all = new List<int>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var a = q.Dequeue();
                all.Add(a.val);

                if (a.left != null)
                {
                    q.Enqueue(a.left);
                }

                if (a.right != null)
                {
                    q.Enqueue(a.right);
                }
            }

            all = all
                .OrderBy(a => a)
                .ToList();

            var p1 = 0;
            var p2 = all.Count - 1;

            while (p1 < p2)
            {
                if (all[p1] + all[p2] == k)
                {
                    return true;
                }

                if (all[p1] + all[p2] > k)
                {
                    p2--;
                }
                else
                {
                    p1++;
                }
            }

            return false;
        }
    }
}
