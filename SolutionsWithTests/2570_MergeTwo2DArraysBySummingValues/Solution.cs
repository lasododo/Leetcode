using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MergeTwo2DArraysBySummingValues
{
    public class Solution
    {
        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            var map = new Dictionary<int, int>();

            foreach (var item in nums1)
            {
                map[item[0]] += item[1];
            }

            foreach (var item in nums2)
            {
                if (map.ContainsKey(item[0]))
                {
                    map[item[0]] += item[1];
                }
                else
                {
                    map[item[0]] = item[1];
                }
            }

            return map
                .OrderBy(a => a.Key)
                .Select(a => new int[] {a.Key, a.Value})
                .ToArray();
        }
    }
}
