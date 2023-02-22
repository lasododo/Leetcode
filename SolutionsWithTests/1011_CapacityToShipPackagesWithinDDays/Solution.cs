using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CapacityToShipPackagesWithinDDays
{
    public class Solution
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            var left = weights.Max();
            var right = weights.Sum();

            while (left <= right)
            {
                var capacity = left + (right - left) / 2;

                if (IsShippable(weights, days, capacity))
                {
                    right = capacity - 1;
                }
                else
                {
                    left = capacity + 1;
                }
            }

            return left;
        }

        private bool IsShippable(int[] weights, int days, int capacity)
        {
            var sum = 0;
            var count = 1;

            foreach (var item in weights)
            {
                if (sum + item > capacity)
                {
                    sum = 0;
                    count++;
                }

                sum += item;
            }

            return count <= days;
        }
    }
}
