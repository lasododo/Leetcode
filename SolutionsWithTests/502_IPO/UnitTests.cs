using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.IPO
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
            var sol = new Solution().FindMaximizedCapital(2, 0, new int[] {1, 2, 3}, new int[] { 0, 1, 1 });
            Assert.That(sol, Is.EqualTo(4));
        }
    }
}
