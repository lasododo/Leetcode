using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.PlusOne
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private int[] ConvertFromIntToArray(int a)
        {
            var list = new List<int>();

            while (a > 0)
            {
                list.Add(a % 10);
                a /= 10;
            }

            return list.Reverse<int>().ToArray();
        }

        [Test]
        public void Test1()
        {
            var inputNum = 1234;
            var inputArray = ConvertFromIntToArray(inputNum);
            var expectedArray = ConvertFromIntToArray(inputNum + 1);

            var actual = new Solution()
                .PlusOne(inputArray);

            Assert.That(expectedArray, Is.EquivalentTo(actual));
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        [Test]
        public void Test2()
        {
            var inputNum = 1236;
            var inputArray = ConvertFromIntToArray(inputNum);
            var expectedArray = ConvertFromIntToArray(inputNum + 1);

            var actual = new Solution()
                .PlusOne(inputArray);

            Assert.That(expectedArray, Is.EquivalentTo(actual));
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        [Test]
        public void Test3()
        {
            var inputNum = 9;
            var inputArray = ConvertFromIntToArray(inputNum);
            var expectedArray = ConvertFromIntToArray(inputNum + 1);

            var actual = new Solution()
                .PlusOne(inputArray);

            Assert.That(expectedArray, Is.EquivalentTo(actual));
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        [Test]
        public void Test4()
        {
            var inputNum = 99999999;
            var inputArray = ConvertFromIntToArray(inputNum);
            var expectedArray = ConvertFromIntToArray(inputNum + 1);

            var actual = new Solution()
                .PlusOne(inputArray);

            Assert.That(expectedArray, Is.EquivalentTo(actual));
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        [Test]
        public void Test5()
        {
            var inputArray = Array.Empty<int>();
            var expectedArray = new int[] { 1 };

            var actual = new Solution()
                .PlusOne(inputArray);

            Assert.That(expectedArray, Is.EquivalentTo(actual));
            CollectionAssert.AreEqual(expectedArray, actual);
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
