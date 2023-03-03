using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FloodFill
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
            var input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            new Solution().FloodFill(input, 1, 1, 2);
        }

        [Test]
        public void Test2()
        {
            var input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }};
            new Solution().FloodFill(input, 1, 1, 2);
        }
    }
}
