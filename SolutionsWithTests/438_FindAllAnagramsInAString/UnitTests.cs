using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FindAllAnagramsInAString
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] public void SortAnArray()
        {
            var res = new Solution().FindAnagrams("abab", "ab");
            var a = 10;
        }
    }
}
