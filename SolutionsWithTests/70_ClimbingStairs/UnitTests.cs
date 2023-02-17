using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ClimbingStairs
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
            var input = 1;
            var expected = 1;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test2()
        {
            var input = 2;
            var expected = 2;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test3()
        {
            var input = 3;
            var expected = 3;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test4()
        {
            var input = 4;
            var expected = 5;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test5()
        {
            var input = 5;
            var expected = 8;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test6()
        {
            var input = 6;
            var expected = 13;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test7()
        {
            var input = 7;
            var expected = 21;

            var actual = new Solution()
                .ClimbStairs(input);

            Assert.That(expected, Is.EqualTo(actual));
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
