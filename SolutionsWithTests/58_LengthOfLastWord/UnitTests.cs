using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LengthOfLastWord
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
            var input = "Hello World";
            var expected = 5;

            var actual = new Solution()
                .LengthOfLastWord(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var input = "   fly me   to   the moon  ";
            var expected = 4;

            var actual = new Solution()
                .LengthOfLastWord(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var input = "luffy is still joyboy";
            var expected = 6;

            var actual = new Solution()
                .LengthOfLastWord(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var input = "        ";
            var expected = 0;

            var actual = new Solution()
                .LengthOfLastWord(input);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void Test5()
        {
            var input = "a";
            var expected = 1;

            var actual = new Solution()
                .LengthOfLastWord(input);

            Assert.That(actual, Is.EqualTo(expected));
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
