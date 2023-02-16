using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.MaximumDepthOfBinaryTree
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_SimpleBT()
        {
            var input = new TreeNode(1, 
                new TreeNode(2, 
                    new TreeNode(21)), 
                new TreeNode(3));
            var expected = 3;

            var actual = new Solution()
                .MaxDepth(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_SimpleBTRight()
        {
            var input = new TreeNode(1,
                new TreeNode(2,
                    null,
                    new TreeNode(21)),
                new TreeNode(3));
            var expected = 3;

            var actual = new Solution()
                .MaxDepth(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Advanced()
        {
            var input = new TreeNode(1,
                new TreeNode(2),
                new TreeNode(3,
                    null,
                    new TreeNode(21)));
            var expected = 3;

            var actual = new Solution()
                .MaxDepth(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        /*
        [Test]
        public void Test_Template()
        {
            // Assert.That(actualInt, Is.EqualTo(3));
            // Assert.That(actualList, Is.EquivalentTo(... list ...));
            // Assert.That(actualBool, Is.True);
        }
        */
    }
}
