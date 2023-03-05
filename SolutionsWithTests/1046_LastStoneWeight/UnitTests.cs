using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.LastStoneWeight
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
            var input = new int[] { 2, 7, 4, 1, 8, 1 };

            var actual = new Solution()
                .LastStoneWeight(input);

            Assert.That(actual, Is.EqualTo(1));
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
