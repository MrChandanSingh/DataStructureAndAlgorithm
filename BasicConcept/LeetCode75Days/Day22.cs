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

        public int ClimbStairs(int n)
        {

            int[] arr = new int[n+2];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;
            for (int i = 3; i <=n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            return arr[n];

        }
    }
}
