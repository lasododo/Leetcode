using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MedianofTwoSortedArrays
{
    public class Solution
    {
        private class IndexHolder
        {
            public int[] NumsArray { get; set; }
            public int LeftIndex { get; set; } = 0;
            public int RightIndex { get; set; } = 0;
            public int MidIndex => (RightIndex + LeftIndex) / 2;

            public int IndexDiff => RightIndex - LeftIndex;
            public int LeftWithMiddleDiff => MidIndex - LeftIndex;
            public int RightMidIndex => RightIndex - LeftWithMiddleDiff;

            public int MidItem => NumsArray[MidIndex];

            public IndexHolder(int[] numsArray) { NumsArray = numsArray; }

            public int[] GetRemainingItems() 
            {
                var items = new List<int>();

                for (int i = LeftIndex; i <= RightIndex; i++)
                {
                    items.Add(NumsArray[i]);
                }

                return items.ToArray();
            }
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return GetMedianFromSingleArray(nums2);
            }

            if (nums2.Length == 0)
            {
                return GetMedianFromSingleArray(nums1);
            }

            var nums1Indexes = new IndexHolder(nums1) { RightIndex = nums1.Length - 1 };
            var nums2Indexes = new IndexHolder(nums2) { RightIndex = nums2.Length - 1 };

            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2Indexes, nums1Indexes);
            }

            return FindMedianSortedArrays(nums1Indexes, nums2Indexes);
        }

        private double FindMedianSortedArrays(IndexHolder smallerArr, IndexHolder biggerArr)
        {
            // there are 2 or less items in the `nums1` (or nums2) array considered to be a median
            if (smallerArr.IndexDiff < 2)
            {
                return GetMedianFromSingleArray(biggerArr, smallerArr.GetRemainingItems());
            }

            if (biggerArr.IndexDiff < 2)
            {
                return GetMedianFromSingleArray(smallerArr, biggerArr.GetRemainingItems());
            }

            // should be always the small one, but just in case
            var moveSize = Math.Min(smallerArr.LeftWithMiddleDiff, biggerArr.RightMidIndex);

            if (smallerArr.MidItem < biggerArr.MidItem)
            {
                smallerArr.LeftIndex += moveSize;
                biggerArr.RightIndex -= moveSize;
            }
            else
            {
                biggerArr.LeftIndex += moveSize;
                smallerArr.RightIndex -= moveSize;
            }

            return FindMedianSortedArrays(smallerArr, biggerArr);
        }

        private static double GetMedianFromSingleArray(IndexHolder remainingArr, int[] leftOvers)
        {
            if (remainingArr.IndexDiff < 5)
            {
                var lo = leftOvers.ToList();
                lo.AddRange(remainingArr.GetRemainingItems());
                lo = lo.OrderBy(a => a).ToList();

                if (lo.Count % 2 == 1)
                {
                    return lo[lo.Count / 2];
                }

                return (lo[lo.Count / 2] + lo[(lo.Count / 2) - 1]) / 2d;
            }

            var list = new List<int>
            {
            };

            var bigArrayLen = remainingArr.IndexDiff + 1;
            var smallArrayLen = leftOvers.Length;
            var bigArrayLenEven = bigArrayLen % 2 == 0;
            var smallArrayLennEven = smallArrayLen % 2 == 0;

            // case 1 even + odd
            if (bigArrayLenEven && smallArrayLennEven)
            {
                list.Add(remainingArr.MidItem);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 1]);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex - 1]);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 2]);
            }

            // case 2 even + even
            if (bigArrayLenEven && !smallArrayLennEven)
            {
                list.Add(remainingArr.MidItem);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 1]);
            }

            // case 3 odd + even
            if (!bigArrayLenEven && smallArrayLennEven)
            {
                list.Add(remainingArr.MidItem);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 1]);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex - 1]);
            }

            // case 4 odd + odd
            if (!bigArrayLenEven && !smallArrayLennEven)
            {
                // todo check around
                list.Add(remainingArr.MidItem);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 1]);
                list.Add(remainingArr.NumsArray[remainingArr.MidIndex - 1]);
            }

            var mid = list.ToList();

            list.AddRange(leftOvers);

            var lst = list.OrderBy(a => a).ToList();

            if (lst.Count % 2 == 1)
            {
                return lst[lst.Count / 2];
            }

            return (lst[lst.Count / 2] + lst[(lst.Count / 2) - 1]) / 2d;
        }

        internal static double GetMedianFromSingleArray(int[] expected)
        {
            if (expected.Length == 0)
            {
                return 0;
            }

            if (expected.Length % 2 == 1)
            {
                return expected[expected.Length / 2];
            }

            var first = expected[expected.Length / 2];
            var second = expected[(expected.Length / 2) - 1];

            return (first + second) / 2d;
        }
    }

    public class SolutionNotWorking
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return GetMedianFromSingleArray(nums2);
            }

            if (nums2.Length == 0)
            {
                return GetMedianFromSingleArray(nums1);
            }

            var left1Index = 0;
            var left2Index = 0;
            var right1Index = nums1.Length - 1;
            var right2Index = nums2.Length - 1;

            while (left1Index <= right1Index && left2Index <= right2Index)
            {
                var mid1Index = (left1Index + right1Index) / 2;
                var mid2Index = (left2Index + right2Index) / 2;

                if (left1Index == mid1Index || left2Index == mid2Index)
                {
                    break;
                }

                var middle1Val = nums1[mid1Index];
                var left1Val = nums1[left1Index];
                var right1Val = nums1[right1Index];

                var middle2Val = nums2[mid2Index];
                var left2Val = nums2[left2Index];
                var right2Val = nums2[right2Index];

                if (left1Val <= left2Val)
                {

                }
            }

            return GetMedianFromSingleArray(nums1);
        }


        private static double GetMedianFromSingleArray(int[] expected, int startIndex, int endIndex)
        {
            if (expected.Length == 0)
            {
                return 0;
            }

            var middleIndexOffset = ((endIndex - startIndex) / 2);

            if ((endIndex - startIndex) % 2 == 0)
            {
                return expected[startIndex + middleIndexOffset];
            }

            var first = expected[startIndex + middleIndexOffset];
            var second = expected[startIndex + middleIndexOffset + 1];

            return (first + second) / 2d;
        }

        internal static double GetMedianFromSingleArray(int[] expected)
        {
            if (expected.Length == 0)
            {
                return 0;
            }

            if (expected.Length % 2 == 1)
            {
                return expected[expected.Length / 2];
            }

            var first = expected[expected.Length / 2];
            var second = expected[(expected.Length / 2) - 1];

            return (first + second) / 2d;
        }

    }

    /*
     * public class Solution
    {
        private class IndexHolder
        {
            public int[] NumsArray { get; set; }
            public int LeftIndex { get; set; } = 0;
            public int RightIndex { get; set; } = 0;
            public int MidIndex => (RightIndex + LeftIndex) / 2;

            public int IndexDiff => RightIndex - LeftIndex;
            public int LeftWithMiddleDiff => MidIndex - LeftIndex;
            public int RightMidIndex => RightIndex - LeftWithMiddleDiff;

            public int LeftItem => NumsArray[LeftIndex];
            public int RightItem => NumsArray[RightIndex];
            public int MidItem => NumsArray[MidIndex];

            public IndexHolder(int[] numsArray) { NumsArray = numsArray; }

            public int[] GetRemainingItems() 
            {
                var items = new List<int>();

                for (int i = LeftIndex; i <= RightIndex; i++)
                {
                    items.Add(NumsArray[i]);
                }

                return items.ToArray();
            }
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return GetMedianFromSingleArray(nums2);
            }

            if (nums2.Length == 0)
            {
                return GetMedianFromSingleArray(nums1);
            }

            var nums1Indexes = new IndexHolder(nums1) { RightIndex = nums1.Length - 1 };
            var nums2Indexes = new IndexHolder(nums2) { RightIndex = nums2.Length - 1 };

            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2Indexes, nums1Indexes);
            }

            return FindMedianSortedArrays(nums1Indexes, nums2Indexes);
        }

        private double FindMedianSortedArrays(IndexHolder smallerArr, IndexHolder biggerArr)
        {
            // there are 2 or less items in the `nums1` (or nums2) array considered to be a median
            if (smallerArr.IndexDiff < 2)
            {
                return GetMedianFromSingleArray(biggerArr, smallerArr.GetRemainingItems());
            }

            if (biggerArr.IndexDiff < 2)
            {
                return GetMedianFromSingleArray(smallerArr, biggerArr.GetRemainingItems());
            }

            // should be always the small one, but just in case
            var moveSize = Math.Min(smallerArr.LeftWithMiddleDiff, biggerArr.RightMidIndex);

            // Debug only
            var originalSL = smallerArr.LeftIndex;
            var originalSR = smallerArr.RightIndex;
            var originalSM = smallerArr.MidIndex;
            var originalSMI = smallerArr.MidItem;
            var originalBL = biggerArr.LeftIndex;
            var originalBR = biggerArr.RightIndex;
            var originalBM = biggerArr.MidIndex;
            var originalBMI = biggerArr.MidItem;

            if (smallerArr.MidItem < biggerArr.MidItem)
            {
                smallerArr.LeftIndex += moveSize;
                biggerArr.RightIndex -= moveSize;
            }
            else
            {
                biggerArr.LeftIndex += moveSize;
                smallerArr.RightIndex -= moveSize;
            }

            return FindMedianSortedArrays(smallerArr, biggerArr);
        }

        private static double GetMedianFromSingleArray(IndexHolder remainingArr, int[] leftOvers)
        {
            if (remainingArr.IndexDiff < 5)
            {
                var lo = leftOvers.ToList();
                lo.AddRange(remainingArr.GetRemainingItems());
                lo = lo.OrderBy(a => a).ToList();

                if (lo.Count % 2 == 1)
                {
                    return lo[lo.Count / 2];
                }

                return (lo[lo.Count / 2] + lo[(lo.Count / 2) - 1]) / 2d;
            }

            var list = new List<int>
            {
                remainingArr.MidItem,
                remainingArr.NumsArray[remainingArr.MidIndex + 1],
                remainingArr.NumsArray[remainingArr.MidIndex - 1],
            };
            list.AddRange(leftOvers);

            if ((remainingArr.IndexDiff + leftOvers.Length) % 2 == 0)
            {
                
            }

            if (leftOvers.Length == 1)
            {
                var index = 2;

                if (leftOvers[0] < remainingArr.MidItem)
                {
                    list.Add(remainingArr.NumsArray[remainingArr.MidIndex + index]);
                }
                else
                {
                    list.Add(remainingArr.NumsArray[remainingArr.MidIndex + index]);
                }
            }
            else
            {
                if (leftOvers[0] > remainingArr.MidItem || leftOvers[1] < remainingArr.MidItem)
                {
                    if (leftOvers[0] > remainingArr.MidItem)
                    {
                        list.Add(remainingArr.NumsArray[remainingArr.MidIndex - 2]);
                        list.Add(remainingArr.NumsArray[remainingArr.MidIndex - 3]);
                    }
                    else
                    {
                        list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 2]);
                        list.Add(remainingArr.NumsArray[remainingArr.MidIndex + 3]);
                    }
                }
            }

            var lst = list.OrderBy(a => a).ToList();

            if (lst.Count % 2 == 1)
            {
                return lst[lst.Count / 2];
            }

            return (lst[lst.Count / 2] + lst[(lst.Count / 2) + 1]) / 2d;
        }

        internal static double GetMedianFromSingleArray(int[] expected)
        {
            if (expected.Length == 0)
            {
                return 0;
            }

            if (expected.Length % 2 == 1)
            {
                return expected[expected.Length / 2];
            }

            var first = expected[expected.Length / 2];
            var second = expected[(expected.Length / 2) - 1];

            return (first + second) / 2d;
        }
    }
     */
}
