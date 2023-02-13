using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PalindromeNumbers
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
            var numberInQuestion = 123456789;

            var actual = new Solution()
                .IsPalindrome(numberInQuestion);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void Test2()
        {
            var numberInQuestion = 12345431;

            var actual = new Solution()
                .IsPalindrome(numberInQuestion);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void Test3()
        {
            var numberInQuestion = -121;

            var actual = new Solution()
                .IsPalindrome(numberInQuestion);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void Test4()
        {
            var numberInQuestion = 121;

            var actual = new Solution()
                .IsPalindrome(numberInQuestion);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Test5()
        {
            var numberInQuestion = 123454321;

            var actual = new Solution()
                .IsPalindrome(numberInQuestion);

            Assert.That(actual, Is.True);
        }
    }
}
