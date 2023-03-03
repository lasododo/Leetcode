using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.ContestTemplate.Easy_Excerice_1
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var nums = new int[] { 10, 4, 8, 3 };
            var expected = new int[] { 15, 1, 11, 22 };
            var res = new Solution().LeftRigthDifference(nums);
            Assert.That(expected, Is.EquivalentTo(res));
        }

        [Test]
        public void Test2()
        {
            var nums = new int[] { 1 };
            var expected = new int[] { 0 };
            var res = new Solution().LeftRigthDifference(nums);
            Assert.That(expected, Is.EquivalentTo(res));
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
