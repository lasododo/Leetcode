using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.IPO
{
    /// <summary>
    /// Runtime 260 ms - Beats 93.94%
    /// Memory 55.9 MB - Beats 63.64%
    /// https://leetcode.com/problems/ipo/submissions/903796239/
    /// 
    /// P.S - GC.Collect memory smasher :D ...
    /// </summary>
    public class Solution
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            if (profits == null || capital == null || profits.Length == 0 || profits.Length != capital.Length)
            {
                return 0;
            }

            var capitalDict = new Dictionary<int, List<int>>();
            var priorityQueueKeys = new PriorityQueue<int, int>();
            var priorityQueueValues = new PriorityQueue<int, int>(new IntMaxCompare());
            var maxUnlockableKey = 0;

            for (int i = 0; i < capital.Length; i++)
            {
                if (!capitalDict.ContainsKey(capital[i]))
                {
                    capitalDict[capital[i]] = new();
                    priorityQueueKeys.Enqueue(capital[i], capital[i]);
                }

                capitalDict[capital[i]].Add(profits[i]);
                maxUnlockableKey = Math.Max(capital[i], maxUnlockableKey);
            }

            var currentCapital = w;
            var currentCapitalWasChanged = true;

            while (k > 0)
            {
                if (currentCapitalWasChanged && priorityQueueKeys.Count > 0)
                {
                    while (priorityQueueKeys.TryPeek(out var _, out var p) && p <= currentCapital)
                    {
                        var key = priorityQueueKeys.Dequeue();

                        foreach (var item in capitalDict[key])
                        {
                            priorityQueueValues.Enqueue(item, item);
                        }
                    }

                    currentCapitalWasChanged = false;
                }

                if (priorityQueueValues.Count == 0)
                {
                    break;
                }

                var max = priorityQueueValues.Dequeue();

                if (max != 0 && currentCapital < maxUnlockableKey)
                {
                    currentCapitalWasChanged = true;
                }

                currentCapital += max;
                k--;
            }
            GC.Collect();
            return currentCapital;
        }

        private class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }
    }

    public class SolutionWorking
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            if (profits == null || capital == null || profits.Length == 0 || profits.Length != capital.Length)
            {
                return 0;
            }

            var capitalDict = new Dictionary<int, PriorityQueue<int, int>>();
            var priorityQueueKeys = new PriorityQueue<int, int>();
            var priorityQueueValues = new PriorityQueue<int, int>(new IntMaxCompare());
            var maxUnlockableKey = 0;

            for (int i = 0; i < capital.Length; i++)
            {
                if (!capitalDict.ContainsKey(capital[i]))
                {
                    capitalDict[capital[i]] = new(new IntMaxCompare());
                    priorityQueueKeys.Enqueue(capital[i], capital[i]);
                }

                capitalDict[capital[i]].Enqueue(profits[i], profits[i]);
                maxUnlockableKey = Math.Max(capital[i], maxUnlockableKey);
            }

            var currentCapital = w;
            var currentCapitalWasChanged = true;

            while (k > 0)
            {
                if (currentCapitalWasChanged && priorityQueueKeys.Count > 0)
                {
                    while (priorityQueueKeys.TryPeek(out var _, out var p) && p <= currentCapital)
                    {
                        var key = priorityQueueKeys.Dequeue();

                        while (capitalDict[key].Count > 0)
                        {
                            var top = capitalDict[key].Dequeue();
                            priorityQueueValues.Enqueue(top, top);
                        }
                    }

                    currentCapitalWasChanged = false;
                }

                if (priorityQueueValues.Count == 0)
                {
                    break;
                }

                var max = priorityQueueValues.Dequeue();

                if (max != 0 && currentCapital < maxUnlockableKey)
                {
                    currentCapitalWasChanged = true;
                }

                currentCapital += max;
                k--;
            }

            return currentCapital;
        }

        private class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }
    }

    /// <summary>
    /// working Solution, but sadly too slow
    /// </summary>
    public class SolutionSlow
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            if (profits == null || capital == null || profits.Length == 0 || profits.Length != capital.Length)
            {
                return 0;
            }

            var capitalDict = new Dictionary<int, PriorityQueue<int, int>>();
            var maximum = 0;

            for (int i = 0; i < capital.Length; i++)
            {
                if (!capitalDict.ContainsKey(capital[i]))
                {
                    capitalDict[capital[i]] = new(new IntMaxCompare());
                }

                capitalDict[capital[i]].Enqueue(profits[i], capital[i]);
                maximum = Math.Max(profits[i], maximum);
            }

            var currentCapital = w;
            var currentCapitalWasChanged = false;
            var allAvailable = capitalDict
                .Where(a => a.Key <= currentCapital);

            var available = allAvailable.FirstOrDefault();

            while (k > 0)
            {
                if (maximum > currentCapital || currentCapitalWasChanged)
                {
                    allAvailable = capitalDict
                        .Where(a => a.Key <= currentCapital)
                        .OrderByDescending(a => a.Value.Peek());
                    currentCapitalWasChanged = false;
                }

                if (!allAvailable.Any())
                {
                    break;
                }

                available = allAvailable.First();
                var max = available.Value.Dequeue();

                if (capitalDict[available.Key].Count == 0)
                {
                    capitalDict.Remove(available.Key);
                    currentCapitalWasChanged = true;
                }

                currentCapital += max;
                k--;
            }

            return currentCapital;
        }

        private class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }
    }
}
