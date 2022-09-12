using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day22
    {
        Dictionary<int, int> days = new Dictionary<int, int>();
        public int Fib(int n)
        {
            if (days.ContainsKey(n))
                return days[n];

            int result = 0;
            if (n < 2)
                return n;
            else
                result = Fib(n - 1)+Fib(n-2);
            days[n] = result;
            
            return result;
        }
    }
}
