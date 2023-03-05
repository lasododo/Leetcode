using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.JumpGameIV
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
            var items = new int[] 
            { 
                51, 64, -15, 58, 98, 31, 48, 72, 78, -63, 92, -5, 64, -64, 51, -48, 64, 48, -76, -86, -5, -64, -86, 
                -47, 92, -41, 58, 72, 31, 78, -15, -76, 72, -5, -97, 98, 78, -97, -41, -47, -86, -97, 78, -97, 58, 
                -41, 72, -41, 72, -25, -76, 51, -86, -65, 78, -63, 72, -15, 48, -15, -63, -65, 31, -41, 95, 51, -47, 
                51, -41, -76, 58, -81, -41, 88, 58, -81, 88, 88, -47, -48, 72, -25, -86, -41, -86, -64, -15, -63
            };

            var actual = new Solution()
                .MinJumps(items);

            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var items = new int[]
            {
                7,6,9,6,9,6,9,7
            };

            var actual = new Solution()
                .MinJumps(items);

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var items = new int[]
            {
                7,6,9,6,9,6,9,7,5,4,4,3,3,2,2,1,1,5
            };

            var actual = new Solution()
                .MinJumps(items);

            Assert.That(actual, Is.EqualTo(3));
        }
    }
}
