using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Medium_1
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
            var expected = new int[] { 1, 1, 0, 0, 0, 1, 1, 0, 0 };
            var res = new Solution().DivisibilityArray("998244353", 3);
            Assert.That(expected, Is.EquivalentTo(res));
        }

        [Test]
        public void Test2()
        {
            var expected = new int[] { 0, 1, 0, 1 };
            var res = new Solution().DivisibilityArray("1010", 10);
            Assert.That(expected, Is.EquivalentTo(res));
        }

        /*
        [Test]
        public void Test_Template()
        {
            // Assert.That(actualInt, Is.EqualTo(3));
            // Assert.That(actualList, Is.EquivalentTo(... list ...));
            // Assert.That(actualBool, Is.True);
        }
        */
    }
}
