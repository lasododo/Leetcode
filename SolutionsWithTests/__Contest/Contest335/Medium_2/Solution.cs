using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.Contest335.Medium_2
{
    // Timedout :(
    public class Solution
    {
        public int FindValidSplit(int[] nums)
        {
            BigInteger sum = 1;
            BigInteger leftSum = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                sum *= (ulong) nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var item = (ulong)nums[i];
                sum /= item;
                leftSum *= item;

                if (sum == 1)
                {
                    return -1;
                }

                if (GCD(sum, leftSum) == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        // I was too lazy to write it myself from scratch
        // https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
        private static BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public ulong gcd(ulong a, ulong b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }
    }
}
