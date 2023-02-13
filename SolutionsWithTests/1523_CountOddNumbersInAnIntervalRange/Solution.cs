using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CountOddNumbersInAnIntervalRange
{
    public class Solution
    {
        /// <summary>
        /// Runtime 29 ms - Beats 73.99%
        /// Memory 26.6 MB - Beats 40.91%
        /// https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/submissions/897370757/
        /// 
        /// => Second Idea is to do it using the bits (I didnt notice it at first and didnt want to delete my current solution)
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int CountOdds(int low, int high)
        {
            var lowAddition = low % 2;
            var highAddition = high % 2;

            var offset = 0;
            
            if (lowAddition == highAddition && lowAddition == 1)
            {
                if (low == high)
                {
                    return low % 2;
                }

                offset++;
            }

            return (high - low - offset) / 2 + lowAddition + highAddition;
        }
    }
}
