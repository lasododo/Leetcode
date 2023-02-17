using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.AddToArrayFormOfInteger
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
            var inputArray = new int[] { 1, 2, 0, 0 };
            var inputK = 34;
            var expected = new int[] { 1, 2, 3, 4 };

            var actual = new Solution()
                .AddToArrayForm(inputArray, inputK);

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual, Is.EquivalentTo(expected.ToList()));

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.That(actual[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test2()
        {
            var inputArray = new int[] { 2, 7, 4 };
            var inputK = 181;
            var expected = new int[] { 4, 5, 5 };

            var actual = new Solution()
                .AddToArrayForm(inputArray, inputK);

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual, Is.EquivalentTo(expected.ToList()));

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.That(actual[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test3()
        {
            var inputArray = new int[] { 2, 1, 5 };
            var inputK = 806;
            var expected = new int[] { 1, 0, 2, 1 };

            var actual = new Solution()
                .AddToArrayForm(inputArray, inputK);

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual, Is.EquivalentTo(expected.ToList()));

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.That(actual[i], Is.EqualTo(expected[i]));
            }
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
