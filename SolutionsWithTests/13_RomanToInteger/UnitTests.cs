using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RomanToInteger
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
            var input = "I";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var input = "II";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var input = "III";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void Test4()
        {
            var input = "IV";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void Test58()
        {
            var input = "LVIII";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(58));
        }

        [Test]
        public void Test1994()
        {
            var input = "MCMXCIV";

            var actual = new Solution()
                .RomanToInt(input);

            Assert.That(actual, Is.EqualTo(1994));
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
