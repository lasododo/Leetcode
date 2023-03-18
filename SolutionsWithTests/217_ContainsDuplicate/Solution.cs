using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    return true;
                }

                set.Add(i);
            }

            return false;
        }
    }
}
