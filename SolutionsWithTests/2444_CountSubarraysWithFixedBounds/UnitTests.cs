using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CountSubarraysWithFixedBounds
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
            var input = new int[] { 1, 3, 5, 2, 7, 5 };

            var actual = new Solution()
                .CountSubarrays(input, 1, 5);

            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 1, 1, 1, 1 };

            var actual = new Solution()
                .CountSubarrays(input, 1, 1);

            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void Test3()
        {
            var input = new int[] { 1, 3, 5, 1, 1, 5, 2, 7, 5, 1, 1, 2, 1, 7, 5, 2, 2, 1 };

            var actual = new Solution()
                .CountSubarrays(input, 2, 5);

            Assert.That(actual, Is.EqualTo(3));
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
