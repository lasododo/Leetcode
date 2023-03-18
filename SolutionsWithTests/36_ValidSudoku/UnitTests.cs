using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidSudoku
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
            var s = new char[][]
            {
                new char[] { '.', '.', '.',  '.', '.', '.',  '.', '.', '2', },
                new char[] { '.', '.', '.',  '.', '.', '.',  '6', '.', '.', },
                new char[] { '.', '.', '1',  '4', '.', '.',  '8', '.', '.', },

                new char[] { '.', '.', '.',  '.', '.', '.',  '.', '.', '.', },
                new char[] { '.', '.', '.',  '.', '.', '.',  '.', '.', '.', },
                new char[] { '.', '.', '.',  '.', '3', '.',  '.', '.', '.', },

                new char[] { '5', '.', '8',  '6', '.', '.',  '.', '.', '.', },
                new char[] { '.', '9', '.',  '.', '.', '.',  '4', '.', '.', },
                new char[] { '.', '.', '.',  '.', '5', '.',  '.', '.', '.', },
            };

            var sol = new Solution()
                .IsValidSudoku(s);

            Assert.IsTrue(sol);
        }
    }
}
