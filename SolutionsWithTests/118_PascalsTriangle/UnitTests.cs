using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PascalsTriangle
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
            var a = new Solution().Generate(5);
            var b = 10;
        }
    }
}
