using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LastStoneWeight
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            var toSkip = 0;
            var stns = stones.ToList();
            while (toSkip < stones.Length)
            {
                var twoMax = stns
                    .Where(x => x > 0)
                    .OrderByDescending(a => a)
                    .Take(2);

                if (!twoMax.Any())
                {
                    return 0;
                }

                toSkip++;

                if (twoMax.Count() == 1)
                {
                    return twoMax.First();
                }

                var first = twoMax.First();
                var second = twoMax.Last();
                stns[stns.IndexOf(first)] = 0;
                var sndIndex = stns.IndexOf(second);
                stns[sndIndex] = 0;

                if (first == second)
                {
                    toSkip++;
                }
                else
                {
                    stns[sndIndex] = Math.Abs(first - second);
                }

            }

            return 0;
        }
    }
}
