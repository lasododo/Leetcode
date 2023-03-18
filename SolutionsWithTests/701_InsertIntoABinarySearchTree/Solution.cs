using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.InsertIntoABinarySearchTree
{
    public class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            InsertInto(root, val);
            return root;
        }

        private void InsertInto(TreeNode root, int val)
        {
            if (root.val == val)
            {
                return;
            }

            if (root.val > val)
            {
                if (root.left != null)
                {
                    InsertInto(root.left, val);
                }
                else
                {
                    root.left = new TreeNode(val);
                }
            }
            else
            {
                if (root.right != null)
                {
                    InsertInto(root.right, val);
                }
                else
                {
                    root.right = new TreeNode(val);
                }
            }
        }
    }
}
