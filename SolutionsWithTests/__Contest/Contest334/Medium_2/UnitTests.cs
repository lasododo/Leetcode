using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Medium_2
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
            var expected = new int[] { 3, 5, 2, 4 };
            var res = new Solution().MaxNumOfMarkedIndices(expected);
            Assert.That(res, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var expected = new int[] { 9, 2, 5, 4 };
            var res = new Solution().MaxNumOfMarkedIndices(expected);
            Assert.That(res, Is.EqualTo(4));
        }

        [Test]
        public void Test3()
        {
            var expected = new int[] { 7, 6, 8 };
            var res = new Solution().MaxNumOfMarkedIndices(expected);
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        public void Test4()
        {
            var expected = new int[] { 42, 83, 48, 10, 24, 55, 9, 100, 10, 17, 17, 99, 51, 32, 16, 98, 99, 31, 28, 68, 71, 14, 64, 29, 15, 40 };
            var res = new Solution().MaxNumOfMarkedIndices(expected);
            Assert.That(res, Is.EqualTo(26));
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
