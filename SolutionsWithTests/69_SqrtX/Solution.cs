using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SqrtX
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            int low = 1, high = x, ans = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (x / mid == mid)
                {
                    return mid;
                }
                else if (x / mid < mid)
                {
                    high = mid - 1;
                }
                else
                { 
                    low = mid + 1; 
                    ans = mid; 
                }
            }

            return ans;
        }
    }
}
