using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ImplementTrie_PrefixTree
{
    public class Solution
    {
        private class Node
        {
            public bool WasInserted { get; set; }

            // O(1) -> limited number of unique characters
            public Dictionary<char, Node> Children { get; set; }
        }

        public class Trie
        {
            private Node Root { get; set; } = new();

            public void Insert(string word)
            {
                var currentNode = Root;
                foreach (var c in word)
                {
                    if (!currentNode.Children.TryGetValue(c, out var node))
                    {
                        currentNode.Children[c] = new Node();
                    }

                    currentNode = currentNode.Children[c];
                }

                currentNode.WasInserted = true;
            }

            public bool Search(string word)
            {
                var currentNode = Root;
                foreach (var c in word)
                {
                    if (!currentNode.Children.TryGetValue(c, out var node))
                    {
                        return false;
                    }

                    currentNode = currentNode.Children[c];
                }

                return currentNode.WasInserted;
            }

            public bool StartsWith(string prefix)
            {
                var currentNode = Root;
                foreach (var c in prefix)
                {
                    if (!currentNode.Children.TryGetValue(c, out var node))
                    {
                        return false;
                    }

                    currentNode = currentNode.Children[c];
                }
                
                return SearchInDepth(currentNode);
            }

            private bool SearchInDepth(Node node)
            {
                foreach (var newNode in node.Children.Values)
                {
                    if (newNode.WasInserted || SearchInDepth(newNode))
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
