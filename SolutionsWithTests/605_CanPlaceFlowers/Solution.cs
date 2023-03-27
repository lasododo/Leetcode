using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                {
                    break;
                }

                var leftIndex = i - 1;
                var rightIndex = i + 1;

                var left = leftIndex >= 0 ? flowerbed[leftIndex] == 0 : true;
                var right = rightIndex < flowerbed.Length ? flowerbed[rightIndex] == 0 : true;

                if (left && right && flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n == 0;
        }
    }
}
