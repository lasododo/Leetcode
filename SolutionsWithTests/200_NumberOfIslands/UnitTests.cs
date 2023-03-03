using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.NumberOfIslands
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
            var input = new char[][] {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
            };
            var res = new Solution().NumIslands(input);
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var input = new char[][] {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' },
            };
            var res = new Solution().NumIslands(input);
            Assert.That(res, Is.EqualTo(3));
        }
    }
}
