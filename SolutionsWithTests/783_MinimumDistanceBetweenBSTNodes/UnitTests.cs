using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionsWithTests.MinimumDistanceBetweenBSTNodes
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
            var inputTree = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)),
                new TreeNode(6));

            var expected = 1;

            var actual = new Solution()
                .MinDiffInBST(inputTree);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void Test2()
        {
            var inputTree = new TreeNode(1,
                new TreeNode(0),
                new TreeNode(48,
                    new TreeNode(12),
                    new TreeNode(49)
                    )
                );

            var expected = 1;

            var actual = new Solution()
                .MinDiffInBST(inputTree);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var inputTree = new TreeNode(90,
                new TreeNode(69,
                    new TreeNode(49,
                        new TreeNode(52)
                        ),
                    new TreeNode(89)
                    )
                );

            var expected = 1;

            var actual = new Solution()
                .MinDiffInBST(inputTree);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
