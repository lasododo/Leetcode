using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LongestCommonPrefix
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
            var input = new string[] { "flower", "flow", "flight" };

            var actual = new Solution()
                .LongestCommonPrefix(input);

            Assert.That(actual, Is.EqualTo("fl"));
        }

        [Test]
        public void Test2()
        {
            var input = new string[] { "dog", "racecar", "car" };

            var actual = new Solution()
                .LongestCommonPrefix(input);

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Test3()
        {
            var input = new string[] { "hello", "hell", "hel" };

            var actual = new Solution()
                .LongestCommonPrefix(input);

            Assert.That(actual, Is.EqualTo("hel"));
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
