using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.AddBinary
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
            var input1 = "11";
            var input2 = "1";

            var actual = new Solution()
                .AddBinary(input1, input2);

            Assert.That(actual, Is.EqualTo("100"));
        }

        [Test]
        public void Test2()
        {
            var input1 = "1010";
            var input2 = "1011";

            var actual = new Solution()
                .AddBinary(input1, input2);

            Assert.That(actual, Is.EqualTo("10101"));
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
