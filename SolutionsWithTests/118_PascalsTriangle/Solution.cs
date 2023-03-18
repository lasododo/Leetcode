using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
            };


            for (int level = 2; level < numRows; level++)
            {
                var arr = new int[level + 1];
                arr[0] = 1;
                arr[level] = 1;
                var endptr = (level - 1);
                for (int i = 1; i <= endptr; i++)
                {
                    arr[i] = res.Last()[i] + res.Last()[i - 1];
                    arr[endptr] = arr[i];
                    endptr--;
                }

                res.Add(arr.ToList());
            }

            if (numRows < 2)
            {
                res = res
                    .Take(numRows)
                    .ToList();
            }
            
            return res;
        }
    }
}
