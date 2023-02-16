using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveElement
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
            var input1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var inputCount = input1.Count();
            var remove = 1;

            var expected = input1.Where(a => a != remove).ToArray();
            var expectedCount = input1.Where(a => a != remove).Count();

            var actualCount = new Solution()
                .RemoveElement(input1, remove);

            Assert.That(actualCount, Is.EqualTo(expectedCount));

            var expectedList = expected
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            var actualDistintList = input1
                .Take(expectedCount)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.That(actualDistintList[i], Is.EqualTo(expectedList[i]));
            }
        }

        [Test]
        public void Test2()
        {
            var input1 = new int[] { 1, 1, 1, 1, 2 };
            var inputCount = input1.Count();
            var remove = 5;

            var expected = input1.Where(a => a != remove).ToArray();
            var expectedCount = input1.Where(a => a != remove).Count();

            var actualCount = new Solution()
                .RemoveElement(input1, remove);

            Assert.That(actualCount, Is.EqualTo(expectedCount));

            var expectedList = expected
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            var actualDistintList = input1
                .Take(expectedCount)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.That(actualDistintList[i], Is.EqualTo(expectedList[i]));
            }
        }

        [Test]
        public void Test3()
        {
            var input1 = new int[] { 2, 2, 2, 1 };
            var inputCount = input1.Count();
            var remove = 1;

            var expected = input1.Where(a => a != remove).ToArray();
            var expectedCount = input1.Where(a => a != remove).Count();

            var actualCount = new Solution()
                .RemoveElement(input1, remove);

            Assert.That(actualCount, Is.EqualTo(expectedCount));

            var expectedList = expected
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            var actualDistintList = input1
                .Take(expectedCount)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.That(actualDistintList[i], Is.EqualTo(expectedList[i]));
            }
        }

        [Test]
        public void Test5()
        {
            var input1 = new int[] { 1 };
            var inputCount = input1.Count();
            var remove = 1;

            var expected = input1.Where(a => a != remove).ToArray();
            var expectedCount = input1.Where(a => a != remove).Count();

            var actualCount = new Solution()
                .RemoveElement(input1, remove);

            Assert.That(actualCount, Is.EqualTo(expectedCount));

            var expectedList = expected
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            var actualDistintList = input1
                .Take(expectedCount)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.That(actualDistintList[i], Is.EqualTo(expectedList[i]));
            }
        }

        [Test]
        public void Test4()
        {
            var input1 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var inputCount = input1.Count();
            var remove = 2;

            var expected = input1.Where(a => a != remove).ToArray();
            var expectedCount = input1.Where(a => a != remove).Count();

            var actualCount = new Solution()
                .RemoveElement(input1, remove);

            Assert.That(actualCount, Is.EqualTo(expectedCount));

            var expectedList = expected
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            var actualDistintList = input1
                .Take(expectedCount)
                .Distinct()
                .OrderBy(a => a)
                .ToList();

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.That(actualDistintList[i], Is.EqualTo(expectedList[i]));
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
