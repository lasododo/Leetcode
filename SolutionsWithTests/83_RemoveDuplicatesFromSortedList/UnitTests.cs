using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace SolutionsWithTests.RemoveDuplicatesFromSortedList
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
            var number = 123456;
            var numberExpected = 123456;
            var listNode = MakeListNode(NumberToList(number));

            var actual = new Solution()
                .DeleteDuplicates(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(NumberToList(numberExpected)));
            CollectionAssert.AreEqual(ListNodeToList(actual), NumberToList(numberExpected));
        }


        [Test]
        public void Test2()
        {
            var number = 111111111;
            var numberExpected = 1;
            var listNode = MakeListNode(NumberToList(number));

            var actual = new Solution()
                .DeleteDuplicates(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(NumberToList(numberExpected)));
            CollectionAssert.AreEqual(ListNodeToList(actual), NumberToList(numberExpected));
        }


        [Test]
        public void Test3()
        {
            var number = 1222333355;
            var numberExpected = 1235;
            var listNode = MakeListNode(NumberToList(number));

            var actual = new Solution()
                .DeleteDuplicates(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(NumberToList(numberExpected)));
            CollectionAssert.AreEqual(ListNodeToList(actual), NumberToList(numberExpected));
        }


        [Test]
        public void Test4()
        {
            var number = 1122334455;
            var numberExpected = 12345;
            var listNode = MakeListNode(NumberToList(number));

            var actual = new Solution()
                .DeleteDuplicates(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(NumberToList(numberExpected)));
            CollectionAssert.AreEqual(ListNodeToList(actual), NumberToList(numberExpected));
        }




        private List<int> NumberToList(int? number)
        {
            var node = new List<int>();

            if (number == null)
            {
                return node;
            }

            if (number == 0)
            {
                return new List<int>() { 0 };
            }

            while (number > 0)
            {
                node.Add(number.Value % 10);
                number /= 10;
            }

            return node;
        }

        private ListNode MakeListNode(List<int> list)
        {
            var original = new ListNode();
            var node = original;

            var counter = 0;

            foreach (var item in list)
            {
                counter += 1;
                node.val = item;

                if (counter < list.Count)
                {
                    node.next = new();
                    node = node.next;
                }
            }

            return original;
        }

        private List<int> ListNodeToList(ListNode node)
        {
            var currentList = new List<int>();
            var current = node;
            var counter = 0;

            while (current != null)
            {
                if (counter >= 100)
                {
                    throw new ArgumentException("Infinite LOOP");
                }

                counter += 1;
                currentList.Add(current.val);
                current = current.next;
            }

            return currentList;
        }
    }
}
