using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MedianofTwoSortedArrays
{
    public class Solution
    {

        private int[] MumbersArray1 { get; set; }
        private int[] MumbersArray2 { get; set; }

        private int BothArraySize { get { return MumbersArray1.Length + MumbersArray2.Length; } }
        private int ArrayMiddleIndex { get { return (BothArraySize - 1) / 2; } }

        /// <summary>
        ///  - A special binary search needs to be implemented
        ///  </summary>
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

            if (nums2.Length < 3 && nums1.Length < 3)
            {
                var list = new List<int>();
                list.AddRange(nums1);
                list.AddRange(nums2);
                return GetMedianFromSingleArray(list.OrderBy(x => x).ToArray());
            }

            MumbersArray1 = nums1;
            MumbersArray2 = nums2;

            var nums1LastIndex = nums1.Length - 1;
            var nums2LastIndex = nums2.Length - 1;

            int i1 = 0;
            int i2 = 0;
            int j1 = nums1LastIndex;
            int j2 = nums2LastIndex;

            return FindMedianSortedArrays(i1, i2, j1, j2);
        }

        public double FindMedianSortedArrays(int i1, int i2, int j1, int j2)
        {
            int oldi1 = i1;
            int oldi2 = i2;
            int oldj1 = j1;
            int oldj2 = j2;

            var firstMidLower = ((i1 + j1) / 2);
            var secondMidLower = ((i2 + j2) / 2);

            var firstMidUpper = (MumbersArray1.Length - 1) - firstMidLower;
            var secondMidUpper = (MumbersArray2.Length - 1) - secondMidLower;

            var firstMidLowerValue = MumbersArray1[firstMidLower];
            var secondMidLowerValue = MumbersArray2[secondMidLower];

            int firstMidUpperValue = 0;
            int secondMidUpperValue = 0;

            if (firstMidUpper == MumbersArray1.Length)
            {
                firstMidUpperValue = MumbersArray1[firstMidLower];
            }
            else
            {
                firstMidUpperValue = MumbersArray1[firstMidUpper];
            }

            if (secondMidUpper == MumbersArray2.Length)
            {
                secondMidUpperValue = MumbersArray2[secondMidLower];
            }
            else
            {
                secondMidUpperValue = MumbersArray2[secondMidUpper];
            }

            var array = new int[] { firstMidLowerValue, firstMidUpperValue, secondMidLowerValue, secondMidUpperValue };

            if (array.Min() == array.Max())
            {
                return firstMidUpperValue;
            }

            if (firstMidLowerValue == secondMidLowerValue)
            {
                if (firstMidLower + secondMidLower <= ArrayMiddleIndex)
                {
                    i1 = firstMidLower;
                }
            }
            else if (firstMidLowerValue < secondMidLowerValue)
            {
                i1 = firstMidLower;
            }
            else
            {
                i2 = secondMidLower;
            }

            if (firstMidUpperValue == secondMidUpperValue)
            {
                if (firstMidLower + secondMidLower <= ArrayMiddleIndex)
                {
                    j1 = firstMidUpper;
                }
            }
            else if (firstMidUpperValue > secondMidUpperValue)
            {
                j2 = secondMidUpper;
            }
            else
            {
                j1 = firstMidUpper;
            }


            if (i1 == oldi1 && j1 == oldj1 && i2 == oldi2 && j2 == oldj2)
            {
                return GetMedianFromSingleArray(array.ToList().OrderBy(a => a).ToArray());
            }

            return FindMedianSortedArrays(i1, i2, j1, j2);

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
}
