using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MergeSortedArray
{
    /// <summary>
    /// Runtime 137 ms - Beats 81.61%
    /// Memory 42.6 MB - Beats 72.89%
    /// https://leetcode.com/problems/merge-sorted-array/submissions/900027203/
    /// </summary>
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n != 0)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    nums1[i + m] = nums2[i];

                    for (int j = i + m; j > 0; j--)
                    {
                        if (nums1[j] > nums1[j - 1])
                        {
                            break;
                        }

                        var toSwap = nums1[j];
                        nums1[j] = nums1[j - 1];
                        nums1[j - 1] = toSwap;
                    }
                }
            }
        }
    }
}
