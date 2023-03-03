using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.FibonacciNumber
{
    public class Solution
    {
        public int Fib(int n)
        {
            var memory = new Dictionary<int, int>();
            
            if (n == 0)
            {
                return 0;
            }

            return Fib(n, memory);
        }

        private int Fib(int n, Dictionary<int, int> memory)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            if (!memory.ContainsKey(n - 2))
            {
                memory[n - 2] = Fib(n - 2, memory);
            }

            if (!memory.ContainsKey(n - 1))
            {
                memory[n - 1] = Fib(n - 1, memory);
            }

            if (!memory.ContainsKey(n))
            {
                memory[n] = memory[n - 1] + memory[n - 2];
            }

            return memory[n] ;
        }
    }
}
