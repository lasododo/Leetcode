using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BestTimeToBuyAndSellStock
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
            var res = new int[] { 7, 1, 5, 3, 6, 4 };

            new Solution().MaxProfit(res);
        }
    }
}
