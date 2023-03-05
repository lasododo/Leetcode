using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.JumpGameIV
{
    public class Solution
    {
        public int MinJumps(int[] arr)
        {
            var moveDict = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!moveDict.ContainsKey(arr[i]))
                {
                    moveDict[arr[i]] = new HashSet<int>();
                }

                moveDict[arr[i]].Add(i);
            }

            var visited = new bool[arr.Length];
            visited[0] = true;
            var queue = new Queue<(int, int)>();
            queue.Enqueue((0, 0));

            while (queue.Count > 0)
            {
                var (itemIndex, depth) = queue.Dequeue();

                var currentItem = arr[itemIndex];

                if (itemIndex == arr.Length - 1)
                {
                    return depth;
                }

                if (arr[arr.Length - 1] == currentItem)
                {
                    return depth + 1;
                }

                if (itemIndex > 0 && !visited[itemIndex - 1])
                {
                    visited[itemIndex - 1] = true;
                    queue.Enqueue((itemIndex - 1, depth + 1));

                    if (arr.Length - 1 == itemIndex - 1)
                    {
                        return depth + 1;
                    }
                }

                if (itemIndex < arr.Length && !visited[itemIndex + 1])
                {
                    visited[itemIndex + 1] = true;
                    queue.Enqueue((itemIndex + 1, depth + 1));

                    if (arr.Length - 1 == itemIndex + 1)
                    {
                        return depth + 1;
                    }
                }

                foreach (var numIndex in moveDict[currentItem])
                {
                    if (!visited[numIndex])
                    {
                        visited[numIndex] = true;
                        queue.Enqueue((numIndex, depth + 1));

                        if (arr.Length - 1 == numIndex)
                        {
                            return depth + 1;
                        }
                    }
                }

                moveDict[currentItem] = new HashSet<int>();
            }

            return -1;
        }
    }
}
