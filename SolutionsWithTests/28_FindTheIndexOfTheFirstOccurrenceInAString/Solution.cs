using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FindTheIndexOfTheFirstOccurrenceInAString
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var indexes = new List<int>();

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length)
                {
                    break;
                }

                if (haystack[i] == needle[0])
                {
                    indexes.Add(i);
                }
            }

            foreach (var index in indexes)
            {
                bool ret = true;
                for (int i = 0; i < needle.Length; i++)
                {
                    if (haystack[i + index] != needle[i])
                    {
                        ret = false;
                        break;
                    }
                }

                if (ret)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
