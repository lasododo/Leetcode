using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SortAnArray
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] public void SortAnArray()
        {
            var inp = new int[] { 5, 4, 3, 2, 6, 3 };
            var res = new Solution().SortArray(inp);
            var a = 10;
        }
    }
}
