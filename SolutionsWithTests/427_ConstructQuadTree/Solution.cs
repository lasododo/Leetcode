using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests._427_ConstructQuadTree
{
    
    public class Solution
    {
        public class IndexHelper
        {
            public int UpperLeftIndex { get; set; }
            public int UpperRightIndex { get; set; }
            public int LowerLeftIndex { get; set; }
            public int LowerRightIndex { get; set; }

            public int MiddleLeftIndex => Math.Abs(LowerLeftIndex - UpperLeftIndex) / 2;
            public int MiddleRightIndex => Math.Abs(LowerRightIndex - UpperRightIndex) / 2;
            public int MiddleUpperIndex => Math.Abs(UpperRightIndex - UpperLeftIndex) / 2;
            public int MiddleLowerIndex => Math.Abs(LowerRightIndex - LowerRightIndex) / 2;
        }

        public Node Construct(int[][] grid)
        {
            var indexHelper = new IndexHelper()
            {
                UpperLeftIndex = 0,
                UpperRightIndex = grid[0].Length - 1,
                LowerLeftIndex = 0,
                LowerRightIndex = grid[0].Length - 1,
            };
            return Construct(grid, indexHelper);
        }

        public Node Construct(int[][] grid, IndexHelper indexHelper)
        {
            var equivalent = grid[indexHelper.UpperLeftIndex][indexHelper.UpperRightIndex];
            var isLeaf = IsLeafNode(grid, indexHelper, equivalent);
            var currentNode = new Node();
            currentNode.isLeaf = isLeaf;
            currentNode.val = equivalent == 1;

            if (!isLeaf)
            {
                currentNode.topLeft = Construct(grid, new IndexHelper 
                { 
                    UpperLeftIndex = indexHelper.UpperLeftIndex,
                    UpperRightIndex = indexHelper.MiddleRightIndex,
                    LowerLeftIndex = indexHelper.MiddleLeftIndex,
                    LowerRightIndex = indexHelper.MiddleRightIndex,
                });
                currentNode.topRight = Construct(grid, new IndexHelper
                {
                    UpperLeftIndex = indexHelper.MiddleLeftIndex,
                    UpperRightIndex = indexHelper.UpperRightIndex,
                    LowerLeftIndex = indexHelper.LowerLeftIndex,
                    LowerRightIndex = indexHelper.LowerRightIndex,
                });
                currentNode.bottomLeft = Construct(grid, new IndexHelper
                {
                    UpperLeftIndex = indexHelper.UpperLeftIndex,
                    UpperRightIndex = indexHelper.UpperRightIndex,
                    LowerLeftIndex = indexHelper.LowerLeftIndex,
                    LowerRightIndex = indexHelper.LowerRightIndex,
                });
                currentNode.bottomRight = Construct(grid, new IndexHelper
                {
                    UpperLeftIndex = indexHelper.UpperLeftIndex,
                    UpperRightIndex = indexHelper.UpperRightIndex,
                    LowerLeftIndex = indexHelper.LowerLeftIndex,
                    LowerRightIndex = indexHelper.LowerRightIndex,
                });
            }

            return currentNode;

        }

        private static bool IsLeafNode(int[][] grid, IndexHelper indexHelper, int equivalent)
        {
            var lowerLeftIndex = indexHelper.LowerLeftIndex;
            var upperLeftIndex = indexHelper.UpperLeftIndex;
            var lowerRightIndex = indexHelper.LowerRightIndex;
            var upperRightIndex = indexHelper.UpperRightIndex;

            for (int l = 0; l < (lowerLeftIndex - upperLeftIndex); l++)
            {
                for (int r = 0; r < (lowerRightIndex - upperRightIndex); r++)
                {
                    if (equivalent != grid[upperLeftIndex][upperRightIndex])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
