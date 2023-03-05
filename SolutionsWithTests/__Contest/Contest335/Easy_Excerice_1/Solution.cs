using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.Contest335.Easy_Excerice_1
{
    public class Solution
    {
        public int PassThePillow(int n, int time)
        {
            if (time == 0)
            {
                return 1;
            }

            var pointer = (time % ((n - 1) * 2)) + 1;
            if (pointer > n)
            {
                pointer = n - (pointer % n);
            }
            return pointer;
        }
    }
}
