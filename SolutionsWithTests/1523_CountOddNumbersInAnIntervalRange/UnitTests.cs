using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CountOddNumbersInAnIntervalRange
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var low = 3;
            var high = 7;

            var actual = new Solution()
                .CountOdds(low, high);

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var low = 8;
            var high = 10;

            var actual = new Solution()
                .CountOdds(low, high);

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var low = 7;
            var high = 10;

            var actual = new Solution()
                .CountOdds(low, high);

            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Test4()
        {
            var low = 8;
            var high = 11;

            var actual = new Solution()
                .CountOdds(low, high);

            Assert.That(actual, Is.EqualTo(2));
        }
    }
}
