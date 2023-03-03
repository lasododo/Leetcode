using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.StringCompression
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var arr = new char[] { 'a', 'b', 'b', 'c' };
            var res = new Solution().Compress(arr);
            var a = 10;
        }
    }
}
