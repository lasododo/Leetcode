using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.RemoveDuplicatesFromSortedArray
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
            var input = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            var expected = input.ToHashSet().ToList().OrderBy(a => a).ToArray();
            var inputLen = input.Length;

            var actual = new Solution()
                .RemoveDuplicates(input);

            Assert.That(input.Length, Is.EqualTo(inputLen));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(input[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 0, 0 };
            var expected = input.ToHashSet().ToList().OrderBy(a => a).ToArray();
            var inputLen = input.Length;

            var actual = new Solution()
                .RemoveDuplicates(input);

            Assert.That(input.Length, Is.EqualTo(inputLen));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(input[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test3()
        {
            var input = new int[] { 0, 0, 1, 1 };
            var expected = input.ToHashSet().ToList().OrderBy(a => a).ToArray();
            var inputLen = input.Length;

            var actual = new Solution()
                .RemoveDuplicates(input);

            Assert.That(input.Length, Is.EqualTo(inputLen));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(input[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test4()
        {
            var input = new int[] { 0 };
            var expected = input.ToHashSet().ToList().OrderBy(a => a).ToArray();
            var inputLen = input.Length;

            var actual = new Solution()
                .RemoveDuplicates(input);

            Assert.That(input.Length, Is.EqualTo(inputLen));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(input[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test5()
        {
            var input = new int[] { 1, 2 };
            var expected = input.ToHashSet().ToList().OrderBy(a => a).ToArray();
            var inputLen = input.Length;

            var actual = new Solution()
                .RemoveDuplicates(input);

            Assert.That(input.Length, Is.EqualTo(inputLen));

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(input[i], Is.EqualTo(expected[i]));
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
