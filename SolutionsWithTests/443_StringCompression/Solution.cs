using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.StringCompression
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            var current = '_';
            var counter = 0;
            var output = string.Empty;
            foreach (var c in chars)
            {
                if (counter == 0)
                {
                    counter = 1;
                    current = c;
                    continue;
                }

                if (c == current)
                {
                    counter++;
                    continue;
                }

                output += current;
                current = c;

                if (counter != 1)
                {
                    foreach (var ch in counter.ToString())
                    {
                        output += ch;
                    }
                }

                counter = 1;
            }

            output += chars[chars.Length - 1];

            if (counter != 1)
            {
                foreach (var ch in counter.ToString())
                {
                    output += ch;
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                chars[i] = output[i];
            }

            return output.Length;
        }
    }
}
