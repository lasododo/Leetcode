using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MedianofTwoSortedArrays
{
    public class Solution
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
}
