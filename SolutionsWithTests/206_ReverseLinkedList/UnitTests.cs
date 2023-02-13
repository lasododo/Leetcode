using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ReverseLinkedList
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
            var number = 12321;
            var numbersInList = NumberToList(number);
            var listNode = MakeListNode(numbersInList);

            var actual = new Solution()
                .ReverseList(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(numbersInList.Reverse<int>().ToList()));
        }

        [Test]
        public void Test2()
        {
            var number = 111221;
            var numbersInList = NumberToList(number);
            var listNode = MakeListNode(numbersInList);

            var actual = new Solution()
                .ReverseList(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(numbersInList.Reverse<int>().ToList()));
        }

        [Test]
        public void Test3()
        {
            var number = 987654;
            var numbersInList = NumberToList(number);
            var listNode = MakeListNode(numbersInList);

            var actual = new Solution()
                .ReverseList(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(numbersInList.Reverse<int>().ToList()));
        }

        [Test]
        public void Test4()
        {
            var number = 1;
            var numbersInList = NumberToList(number);
            var listNode = MakeListNode(numbersInList);

            var actual = new Solution()
                .ReverseList(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(numbersInList.Reverse<int>().ToList()));
        }

        [Test]
        public void Test5()
        {
            var number = 112233445;
            var numbersInList = NumberToList(number);
            var listNode = MakeListNode(numbersInList);

            var actual = new Solution()
                .ReverseList(listNode);

            Assert.That(ListNodeToList(actual), Is.EquivalentTo(NumberToList(544332211)));
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
