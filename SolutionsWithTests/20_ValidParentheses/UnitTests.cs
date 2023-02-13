using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidParentheses
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
            var input = "()";

            var actual = new Solution()
                .IsValid(input);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Test2()
        {
            var input = "()[]{}";

            var actual = new Solution()
                .IsValid(input);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Test3()
        {
            var input = "(]";

            var actual = new Solution()
                .IsValid(input);

            Assert.That(actual, Is.False);
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
