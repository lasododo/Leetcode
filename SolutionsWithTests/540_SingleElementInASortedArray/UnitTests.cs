using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SingleElementInASortedArray
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
            var inputArr = new int[] { 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var inputArr = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var inputArr = new int[] { 3, 3, 7, 7, 10, 11, 11 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(10));
        }

        [Test]
        public void Test4()
        {
            var inputArr = new int[] { 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(1));
        }

        [Test]
        public void Test5()
        {
            var inputArr = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(10));
        }

        [Test]
        public void Test6()
        {
            var inputArr = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(11));
        }

        [Test]
        public void Test7()
        {
            var inputArr = new int[] { 1 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(1));
        }

        [Test]
        public void Test8()
        {
            var inputArr = new int[] { 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6, 7, 7 };

            var output = new Solution().SingleNonDuplicate(inputArr);

            Assert.That(output, Is.EqualTo(4));
        }
    }
}
