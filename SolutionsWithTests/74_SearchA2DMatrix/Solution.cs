using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SearchA2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var left = 0;
            var right = matrix.Length - 1;
            var index = GetFirstIndex(matrix, target, left, right);
            return CheckContains(matrix[index], target, 0, matrix[index].Length - 1);
        }

        private static int GetFirstIndex(int[][] matrix, int target, int left, int right)
        {
            if (left >= right)
            {
                return left;
            }

            var mid = (right + left) / 2;
            var lastFromMid = matrix[mid].Last();

            if (matrix[mid][0] <= target && lastFromMid >= target)
            {
                return mid;
            }

            if (lastFromMid < target)
            {
                return GetFirstIndex(matrix, target, mid + 1, right);
            }

            return GetFirstIndex(matrix, target, left, mid - 1);
        }

        private static bool CheckContains(int[] matrix, int target, int left, int right)
        {
            if (left >= right)
            {
                return left == right ? matrix[left] == target : false;
            }

            var mid = (right + left) / 2;

            if (matrix[mid] == target)
            {
                return true;
            }

            if (matrix[mid] < target)
            {
                return CheckContains(matrix, target, mid + 1, right);
            }
            return CheckContains(matrix, target, left, mid - 1);

        }
    }
}
