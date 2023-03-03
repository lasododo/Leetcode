using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MedianofTwoSortedArrays
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Timeout(2000)]
        public void TestHelperMethod()
        {
            var array1 = new int[] { 1, 3 };
            var array2 = new int[] { 2 };
            double expected = GetExpectedFromArray(array1, array2);
            double result = 2;
            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { 1, 2 };
            array2 = new int[] { 3, 4 };
            expected = GetExpectedFromArray(array1, array2);
            result = 2.5;
            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { 1, 2, 3 };
            array2 = new int[] { };
            expected = GetExpectedFromArray(array1, array2);
            result = 2;
            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { 1, 2, 3, 4 };
            array2 = new int[] { };
            expected = GetExpectedFromArray(array1, array2);
            result = 2.5;
            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { };
            array2 = new int[] { };
            expected = GetExpectedFromArray(array1, array2);
            result = 0;
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test, Timeout(100)]
        public void TestEdgeCases()
        {
            var array1 = new int[] { 1 };
            var array2 = new int[] { 2 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { 2 };
            array2 = new int[] { 1 };
            expected = GetExpectedFromArray(array1, array2);

            result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { 1 };
            array2 = new int[] {  };
            expected = GetExpectedFromArray(array1, array2);

            result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));

            array1 = new int[] { };
            array2 = new int[] { 5 };
            expected = GetExpectedFromArray(array1, array2);

            result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAdvanced1()
        {
            var array1 = new int[] { 1 };
            var array2 = new int[] { 1, 2, 3 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAdvanced2()
        {
            var array1 = new int[] { 1, 2 };
            var array2 = new int[] { 1, 2, 3 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAdvanced3()
        {
            var array1 = new int[] { 1, 2, 3 };
            var array2 = new int[] { 1, 2 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAdvanced4()
        {
            var array1 = new int[] { 1, 2, 3 };
            var array2 = new int[] { 1 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAllTheSameNumbers()
        {
            var array1 = new int[] { 1, 1, 1, 1, 1, 1 };
            var array2 = new int[] { 1, 1, 1, 1, 1, 1 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAllTheSameNumbersWithFirstEmpty()
        {
            var array1 = new int[] {  };
            var array2 = new int[] { 1, 1, 1, 1, 1, 1 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesAllTheSameNumbersWithSecondEmpty()
        {
            var array1 = new int[] { 1, 1, 1, 1, 1, 1 };
            var array2 = new int[] { };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesOneArrayFullOfSameNumbers1()
        {
            var array1 = new int[] { 1, 1, 1, 1, 1, 1 };
            var array2 = new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesOneArrayFullOfSameNumbers2()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array2 = new int[] { 1, 1, 1, 1, 1, 1 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesOneArrayFullOfSameNumbers3()
        {
            var array1 = new int[] { 1, 1, 1, 1, 1, 1 };
            var array2 = new int[] { 1, 2, 3 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEdgeCasesOneArrayFullOfSameNumbers4()
        {
            var array1 = new int[] { 8, 9, 10 };
            var array2 = new int[] { 1, 1, 1, 1, 1, 1 };
            var expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void Test1()
        {
            var array1 = new int[] { 1, 3 };
            var array2 = new int[] { 2 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void Test2()
        {
            var array1 = new int[] { 1, 2 };
            var array2 = new int[] { 3, 4 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void Test3()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var array2 = new int[] { 1, 2, 3, 4, 5, 7 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void Test4()
        {
            var array1 = new int[] { 1 };
            var array2 = new int[] { 2, 3, 4, 5, 6, 7 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void Test5()
        {
            var array1 = new int[] { 4 };
            var array2 = new int[] { 1, 2, 3, 5, 6, 7 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestLoop()
        {
            for (int i = -10; i < 10; i++)
            {
                var array1 = new int[] { i };
                var array2 = Enumerable.Range(i, 11 - i).Where(a => a != i).ToArray();
                double expected = GetExpectedFromArray(array1, array2);

                var result = new Solution()
                    .FindMedianSortedArrays(array1, array2);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [Test, Timeout(100)]
        public void TestOddLengthSingleEmpty1()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var array2 = new int[] { };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestOddLengthSingleEmpty2()
        {
            var array1 = new int[] { };
            var array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEvenLengthSingleEmpty1()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var array2 = new int[] { };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestEvenLengthSingleEmpty2()
        {
            var array1 = new int[] { };
            var array2 = new int[] { 1, 2, 3, 4, 5, 6 };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test, Timeout(100)]
        public void TestDoubleEmpty()
        {
            var array1 = new int[] { };
            var array2 = new int[] { };
            double expected = GetExpectedFromArray(array1, array2);

            var result = new Solution()
                .FindMedianSortedArrays(array1, array2);

            Assert.That(result, Is.EqualTo(expected));
        }

        private static double GetExpectedFromArray(int[] array1, int[] array2)
        {
            var expectedList = new List<int>();
            expectedList.AddRange(array1);
            expectedList.AddRange(array2);

            var expected = expectedList
                .OrderBy(a => a)
                .ToArray();

            return Solution.GetMedianFromSingleArray(expected);

        }
    }
}
