using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class BitSetProblem
    {
        public void CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            Console.WriteLine(count);
        }
    }
}
