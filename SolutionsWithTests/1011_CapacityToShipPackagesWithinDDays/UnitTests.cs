using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.CapacityToShipPackagesWithinDDays
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
            var res = new int[] { 3, 2, 2, 4, 1, 4 };

            var result = new Solution()
                .ShipWithinDays(res, 3);
        }
    }
}
