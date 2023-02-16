using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.AddToArrayFormOfInteger
{
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            var resutList = new List<int>();

            var movedForward = 0;

            int numIndex = num.Length - 1;

            while (numIndex >= 0 || k > 0)
            {
                if (numIndex >= 0)
                {
                    resutList.Add((num[numIndex] + (k % 10) + movedForward) % 10);
                    movedForward = (num[numIndex] + (k % 10) + movedForward) / 10;
                    numIndex--;
                }
                else
                {
                    resutList.Add(((k % 10) + movedForward) % 10);
                    movedForward = ((k % 10) + movedForward) / 10;
                }

                k /= 10;
            }

            if (movedForward != 0)
            {
                resutList.Add(movedForward);
            }

            return resutList.Reverse<int>().ToList();
        }
    }
}
