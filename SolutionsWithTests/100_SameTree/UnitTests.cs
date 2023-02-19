using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.SameTree
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

            var actual = new Solution()
                .IsSameTree(inputTree, inputTree);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Test2()
        {
            var inputTree = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3, 
                        new TreeNode(2,
                            new TreeNode(1),
                            new TreeNode(3)
                            )
                        )),
                new TreeNode(6));

            var actual = new Solution()
                .IsSameTree(inputTree, inputTree);

            Assert.That(actual, Is.True);
        }


        [Test]
        public void Test3()
        {
            var inputTree = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)),
                new TreeNode(6));

            var inputTree2 = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)),
                new TreeNode(7));

            var actual = new Solution()
                .IsSameTree(inputTree, inputTree2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void Test4()
        {
            var inputTree = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(3)),
                new TreeNode(6));

            var inputTree2 = new TreeNode(4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)),
                new TreeNode(6));

            var actual = new Solution()
                .IsSameTree(inputTree, inputTree2);

            Assert.That(actual, Is.False);
        }
    }
}
