using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day26
    {
        public int FindKthGrammer(int n,int k)
        {
            if (n == 1)
                return 0;

            int result = FindKthGrammer(n - 1, (k + 1) / 2);
            if (result % 2 == 0)
                return result == 0 ? 1 : 0;
            else
                return result;
        }
    }
}
