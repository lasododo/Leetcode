using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FibonacciNumber
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
            var r = new Solution().Fib(5);
        }

        [Test]
        public void Test2()
        {
            var r = new Solution().Fib(100);
        }

        [Test]
        public void Test3()
        {
            var r = new Solution().Fib(1000);
        }
    }
}
