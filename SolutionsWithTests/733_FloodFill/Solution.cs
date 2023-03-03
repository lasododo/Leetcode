using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionsWithTests.FloodFill
{
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var xLen = image.GetLength(0) - 1;
            var wanted = image[sr][sc];
            if (wanted == color)
            {
                return image;
            }

            var queue = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();
            queue.Enqueue((sr, sc));
            
            while(queue.Count > 0) 
            {
                var (x, y) = queue.Dequeue();

                var around = new List<(int, int)>();
                image[x][y] = color;
                var yLen = image[x].Length - 1;

                if (x != 0)
                {
                    around.Add((x - 1, y));
                }

                if (x != xLen)
                {
                    around.Add((x + 1, y));
                }

                if (y != 0)
                {
                    around.Add((x, y - 1));
                }

                if (y != yLen)
                {
                    around.Add((x, y + 1));
                }

                foreach (var item in around)
                {
                    if (image[item.Item1][item.Item2] == wanted && !visited.Contains(item))
                    {
                        queue.Enqueue(item);
                        visited.Add(item);
                    }
                }
            }

            return image;
        }
    }
}
