using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BullsAndCows
{
    public class Solution
    {
        public string GetHint(string secret, string guess)
        {
            if (secret.Length != guess.Length)
            {
                return string.Empty;
            }

            var bulls = 0;
            var left = new Dictionary<char, int>();
            var right = new Dictionary<char, int>();

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls++;
                    continue;
                }

                if (!left.ContainsKey(secret[i]))
                {
                    left[secret[i]] = 0;
                }

                if (!right.ContainsKey(guess[i]))
                {
                    right[guess[i]] = 0;
                }

                left[secret[i]] += 1;
                right[guess[i]] += 1;
            }

            var cows = 0;

            foreach (var k in secret)
            {
                if (!left.ContainsKey(k) || left[k] <= 0)
                {
                    continue;
                }

                if (right.ContainsKey(k) && right[k] > 0)
                {
                    right[k] -= 1;
                    left[k] -= 1;
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}
