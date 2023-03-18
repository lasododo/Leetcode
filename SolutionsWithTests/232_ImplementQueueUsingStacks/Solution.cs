using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ImplementQueueUsingStacks
{
    public class Solution
    {
        public class MyQueue
        {
            private Stack<int> queue = new Stack<int>();
            private Stack<int> helperStack1 = new Stack<int>();

            public MyQueue()
            {

            }

            public void Push(int x)
            {
                helperStack1 = new();

                while (queue.Count > 0)
                {
                    helperStack1.Push(queue.Pop());
                }

                queue.Push(x);

                while (helperStack1.Count > 0)
                {
                    queue.Push(helperStack1.Pop());
                }
            }

            public int Pop()
            {
                return queue.Pop();
            }

            public int Peek()
            {
                return queue.Peek();
            }

            public bool Empty()
            {
                return queue.Count == 0;
            }
        }
    }
}
