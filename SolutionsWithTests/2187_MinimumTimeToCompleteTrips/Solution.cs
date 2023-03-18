using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MinimumTimeToCompleteTrips
{
    public class Solution
    {
        public long MinimumTime(int[] time, int totalTrips)
        {
            long start = 1;
            // Magical constant ... I wanted to yeet myself to oblivion
            long end = 100000000000000L;

            while (start <= end)
            {
                long minTimeForTotalTrips = 0;
                long mid = start + (end - start) / 2;

                foreach (var t in time)
                {
                    minTimeForTotalTrips += mid / t;
                }

                if (minTimeForTotalTrips >= totalTrips)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
