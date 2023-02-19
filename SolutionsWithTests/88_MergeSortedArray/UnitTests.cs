using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace SolutionsWithTests.MergeSortedArray
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
            var input = new int [] { 1, 2, 3, 0, 0, 0 };
            var inputCount1 = 3;
            var input2 = new int[] { 2, 3, 4 };
            var inputCount2 = 3;
            var expected = new int[] { 1, 2, 2, 3, 3, 4 };

            new Solution().Merge(input, inputCount1, input2, inputCount2);

            Assert.That(input, Is.EquivalentTo(expected));
            CollectionAssert.AreEqual(input, expected);
        }

    }
}
