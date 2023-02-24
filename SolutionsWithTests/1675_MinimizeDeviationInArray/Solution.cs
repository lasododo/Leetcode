using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionsWithTests.MinimizeDeviationInArray
{
    public class Solution
    {
        public int MinimumDeviation(int[] nums)
        {
            var priorityQueue = new PriorityQueue<int, int>(new IntMaxCompare());
            int globalMinimum = int.MaxValue;

            foreach (var item in nums)
            {
                var newItem = item;
                if (item % 2 == 1)
                {
                    newItem *= 2;
                }
                priorityQueue.Enqueue(newItem, newItem);
                globalMinimum = Math.Min(globalMinimum, newItem);
            }

            int minDeviation = int.MaxValue;
            while (true)
            {
                int max = priorityQueue.Dequeue();
                minDeviation = Math.Min(minDeviation, max - globalMinimum);

                if (max % 2 == 1)
                {
                    break;
                }

                max /= 2;
                globalMinimum = Math.Min(globalMinimum, max);
                priorityQueue.Enqueue(max, max);
            }
            return minDeviation;
        }

        private class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }
    }

    public class SolutionFailed
    {
        public int MinimumDeviation(int[] nums)
        {
            var oddMinimalSet = new HashSet<(int, int)>();
            var maxTwoPowerResult = 0;
            var minTwoPowerResult = int.MaxValue;

            foreach (var item in nums.Distinct())
            {
                var itemCopy = item;

                // make odd or '2'
                while (itemCopy % 2 != 1)
                {
                    if (itemCopy == 2)
                    {
                        break;
                    }

                    itemCopy /= 2;
                }

                if (itemCopy == 2)
                {
                    maxTwoPowerResult = Math.Max(maxTwoPowerResult, item);
                    minTwoPowerResult = Math.Min(minTwoPowerResult, item);
                }

                oddMinimalSet.Add((itemCopy, itemCopy));
            }

            if (oddMinimalSet.Count == 1)
            {
                return nums[0];
            }

            /*
             * Notes for self: with minimal set, the only edge case for me is the '2'.
             * Therefore, I can multiply the values until I reach the minimal output
             * 
             * Additional Edge Case -> '2' multipliers ... we cannot go against a certain trashhold
             */

            var changeOccured = true;

            while (changeOccured)
            {
                var orderedWithoutDuplicates = oddMinimalSet.ToHashSet();
                var min = orderedWithoutDuplicates.Min();
                var max = orderedWithoutDuplicates.Max();
                changeOccured = false;
                var minMaxRecalculation = false;

                foreach (var item in orderedWithoutDuplicates)
                {
                    var diff = max.Item1 - min.Item1;
                    var newItem = item.Item1;
                    oddMinimalSet.Remove(item);

                    if (min.Item1 == newItem)
                    {
                        min = oddMinimalSet.Min();
                        minMaxRecalculation = true;
                    }

                    if (max.Item1 == newItem)
                    {
                        max = oddMinimalSet.Max();
                        minMaxRecalculation = true;
                    }

                    if (minMaxRecalculation) { diff = max.Item1 - min.Item1; }

                    var isPowerOfTwo = item.Item2 == 2;

                    // 2 can be multiplied multiple times
                    if (isPowerOfTwo && maxTwoPowerResult >= newItem * 2)
                    {
                        newItem *= 2;
                    }

                    // odd numbers can be multiplied just once
                    if (!isPowerOfTwo && newItem % 2 == 1)
                    {
                        newItem *= 2;
                    }

                    if (!IsNewValueBetter(newItem, min.Item1, max.Item1, diff))
                    {
                        oddMinimalSet.Add(item);

                        if (minMaxRecalculation)
                        {
                            min = oddMinimalSet.Min();
                            max = oddMinimalSet.Max();
                        }

                        continue;
                    }

                    if (!changeOccured && item.Item1 != newItem && !oddMinimalSet.Contains((newItem, item.Item2)))
                    {
                        changeOccured = true;
                    }

                    oddMinimalSet.Add((newItem, item.Item2));

                    if (minMaxRecalculation)
                    {
                        min = oddMinimalSet.Min();
                        max = oddMinimalSet.Max();
                    }

                    var a = 10;
                }

                var b = 10;
            }

            if (minTwoPowerResult < oddMinimalSet.Select(a => a.Item1).Min())
            {
                oddMinimalSet.Add((minTwoPowerResult, minTwoPowerResult));
            }
            
            return oddMinimalSet.Select(a => a.Item1).Max() - oddMinimalSet.Select(a => a.Item1).Min();
        }

        private static bool IsNewValueBetter(int num, int setMin, int setMax, int startDiff)
        {
            var minNum = num;
            var diff = setMax - setMin;

            var maxDiff = Math.Abs(setMax - num);
            var minDiff = Math.Abs(setMin - num);
            var oldMaxDiff = Math.Abs(setMax - num / 2);
            var oldMinDiff = Math.Abs(setMin - num / 2);

            if (setMax == setMin)
            {
                return Math.Abs(setMax - num / 2) > maxDiff;
            }

            if (minDiff < diff && maxDiff < diff)
            {
                return true;
            }

            if (minNum <= setMin && minDiff < oldMinDiff)
            {
                // return minDiff < Math.Abs(setMin - num / 2);
                return minDiff < oldMinDiff;
            }

            if (minNum >= setMax && maxDiff < oldMaxDiff)
            {
                return (maxDiff + minDiff < oldMaxDiff + oldMinDiff);
            }

            return false;
        }
    }

    public class SolutionPartial
    {
        public int MinimumDeviation(int[] nums)
        {
            var oddMinimalSet = new HashSet<int>();

            foreach (var item in nums)
            {
                var itemCopy = item;
                // odd
                while (itemCopy % 2 != 1)
                {
                    if (itemCopy == 2)
                    {
                        break;
                    }

                    itemCopy /= 2;
                }

                oddMinimalSet.Add(itemCopy);
            }

            var oldmax = oddMinimalSet.Max();
            var oldmin = oddMinimalSet.Min();
            var diff = oldmax - oldmin;

            var newSet = new HashSet<int>();

            foreach (var item in oddMinimalSet.OrderBy(x => x))
            {
                var newItemEven = item;

                if (newItemEven % 2 == 1)
                {
                    newItemEven *= 2;
                }

                var maxDiff = Math.Abs(oldmax - newItemEven);
                var minDiff = Math.Abs(oldmin - newItemEven);

                if (item == oldmin && maxDiff < diff)
                {
                    newSet.Add(newItemEven);
                    continue;
                }

                if (minDiff < diff && maxDiff < diff)
                {
                    newSet.Add(newItemEven);
                }
                else
                {
                    newSet.Add(item);
                }
            }

            return newSet.Max() - newSet.Min();
        }
    }
}
