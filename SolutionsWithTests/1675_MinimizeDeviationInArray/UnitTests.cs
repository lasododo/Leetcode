using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MinimizeDeviationInArray
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
            var res = new Solution().MinimumDeviation(new int[] { 7, 8, 9, 10 });
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Test1()
        {
            var res = new Solution().MinimumDeviation(new int[] { 4, 1, 5, 20, 3 });
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var res = new Solution().MinimumDeviation(new int[] { 1, 2, 3, 4 });
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var res = new Solution().MinimumDeviation(new int[] { 3, 5 });
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test4()
        {
            var res = new Solution().MinimumDeviation(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.That(res, Is.EqualTo(13));
        }


        [Test]
        public void Test5()
        {
            var res = new Solution().MinimumDeviation(new int[] { 2, 10, 8 });
            Assert.That(res, Is.EqualTo(3));
        }


        [Test]
        public void Test6()
        {
            var res = new Solution().MinimumDeviation(new int[] { 14, 16, 9, 10 });
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Test7()
        {
            var res = new Solution().MinimumDeviation(new int[] { 8, 10, 2, 1 });
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Test8()
        {
            var res = new Solution().MinimumDeviation(new int[] { 8, 4, 10, 4, 9 });
            Assert.That(res, Is.EqualTo(5));
        }
    }
}
