using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BullsAndCows
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var res = new Solution()
                .GetHint("1122", "2211");
            var a = 10;
        }
    }
}
