using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.__Contest.Contest335.Easy_Excerice_1
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
            var res = new Solution().PassThePillow(4, 0);
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var res = new Solution().PassThePillow(4, 1);
            Assert.That(res, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var res = new Solution().PassThePillow(4, 2);
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Test4()
        {
            var res = new Solution().PassThePillow(4, 3);
            Assert.That(res, Is.EqualTo(4));
        }

        [Test]
        public void Test5()
        {
            var res = new Solution().PassThePillow(4, 4);
            Assert.That(res, Is.EqualTo(3));
        }


        [Test]
        public void Test6()
        {
            var res = new Solution().PassThePillow(4, 5);
            Assert.That(res, Is.EqualTo(2));
        }

        [Test]
        public void Test7()
        {
            var res = new Solution().PassThePillow(4, 6);
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test8()
        {
            var res = new Solution().PassThePillow(4, 7);
            Assert.That(res, Is.EqualTo(2));
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
