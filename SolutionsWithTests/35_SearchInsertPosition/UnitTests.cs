using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SearchInsertPosition
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
            var inputArray = new int[] { 1, 3, 5, 6 };
            var inputK = 5;
            var expected = 2;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test2()
        {
            var inputArray = new int[] { 1, 3, 5, 6 };
            var inputK = 2;
            var expected = 1;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test3()
        {
            var inputArray = new int[] { 1, 3, 5, 6 };
            var inputK = 7;
            var expected = 4;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void Test4()
        {
            var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var inputK = 20;
            var expected = inputArray.Length;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test5()
        {
            var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var inputK = 20;
            var expected = inputArray.Length;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test6()
        {
            var inputArray = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var inputK = 20;
            var expected = inputArray.Length;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test7()
        {
            var inputArray = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var inputK = 20;
            var expected = inputArray.Length;

            var actual = new Solution()
                .SearchInsert(inputArray, inputK);

            Assert.That(expected, Is.EqualTo(actual));
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
