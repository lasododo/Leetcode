using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.NumberOfIslands
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var xLen = grid.GetLength(0) - 1;
            var queue = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();
            var count = 0;

            for (int i = 0; i <= xLen; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1' && !visited.Contains((i, j)))
                    {
                        queue.Enqueue((i, j));
                        visited.Add((i, j));
                        BFSRun(grid, xLen, queue, visited);
                        count++;
                    }
                }
            }

            return count;
        }

        private static void BFSRun(char[][] grid, int xLen, Queue<(int, int)> queue, HashSet<(int, int)> visited)
        {
            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();

                var around = new List<(int, int)>();
                var yLen = grid[x].Length - 1;

                if (x != 0) { around.Add((x - 1, y)); }
                if (x != xLen) { around.Add((x + 1, y)); }
                if (y != 0) { around.Add((x, y - 1)); }
                if (y != yLen) { around.Add((x, y + 1)); }

                foreach (var item in around)
                {
                    if (grid[item.Item1][item.Item2] == '1' && !visited.Contains(item))
                    {
                        queue.Enqueue(item);
                        visited.Add(item);
                    }
                }
            }
        }
    }
}
