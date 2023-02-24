using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.NaryTreePreorderTraversal
{
    public class Solution
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();

            if (root == null) { return result; }

            PreorderTraversal(root, result);

            return result;
        }

        public void PreorderTraversal(Node root, List<int> nodes)
        {
            if (root == null) { return; }

            nodes.Add(root.val);

            if (root.children == null) { return; }

            foreach (var child in root.children)
            {
                PreorderTraversal(child, nodes);
            }
        }
    }
}
