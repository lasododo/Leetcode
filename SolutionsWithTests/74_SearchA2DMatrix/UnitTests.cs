using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SearchA2DMatrix
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
            var a = new int[][] 
            {
                new int[] {1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] {23, 30, 34, 60 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 3);

            Assert.True(sol);
        }

        [Test]
        public void Test2()
        {
            var a = new int[][]
            {
                new int[] {1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] {23, 30, 34, 60 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 13);

            Assert.True(!sol);
        }

        [Test]
        public void Test5()
        {
            var a = new int[][]
            {
                new int[] {1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] {23, 30, 34, 60 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 4);

            Assert.True(!sol);
        }

        [Test]
        public void Test6()
        {
            var a = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 11);

            Assert.True(sol);
        }

        [Test]
        public void Test3()
        {
            var a = new int[][]
            {
                new int[] {1, 1 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 2);

            Assert.True(!sol);
        }

        [Test]
        public void Test4()
        {
            var a = new int[][]
            {
                new int[] { 1 },
                new int[] { 3 },
            };

            var sol = new Solution()
                .SearchMatrix(a, 0);

            Assert.True(!sol);
        }
    }
}
