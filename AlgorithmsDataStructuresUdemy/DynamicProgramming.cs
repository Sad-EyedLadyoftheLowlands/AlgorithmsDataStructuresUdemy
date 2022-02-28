using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresUdemy
{
    public class DynamicProgramming
    {
        public int RecursiveFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;       
            }

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public int MemoizedRecursiveFibonacciArray(int n, int[] storedResponses)
        {
            if (storedResponses.Length <= n)
                throw new IndexOutOfRangeException("Array must be of length n + 1.");
            
            if (storedResponses[n] != 0)
                return storedResponses[n];

            if (n <= 2)
                return 1;

            var result = MemoizedRecursiveFibonacciArray(n - 1, storedResponses) +
                             MemoizedRecursiveFibonacciArray(n - 2, storedResponses);

            storedResponses[n] = result;

            return result;
        }

        public int MemoizedRecursiveFibonacciDict(int n, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(n))
                return dict[n];
            
            
            if (n <= 2) 
                return 1;

            var result = MemoizedRecursiveFibonacciDict(n - 1, dict) +
                         MemoizedRecursiveFibonacciDict(n - 2, dict);

            dict.TryAdd(n, result);

            return result;
        }

        public long TabulatedFibonacciArray(int n)
        {
            if (n <= 2)
                return 1;

            var storedResponses = new long[n + 1];
            storedResponses[1] = 1;
            storedResponses[2] = 1;

            for (var i = 3; i <= n; i++)
            {
                storedResponses[i] = storedResponses[i - 1] + storedResponses[i - 2];
            }

            return storedResponses[n];
        }
    }
}
