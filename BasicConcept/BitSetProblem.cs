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

        public void CountTotalSetBit(int n)
        {
            int bitCount = 0;
            for(int i = 0; i < n; i++)
            {
                bitCount += CountTotalSetBitUtil(i);
            }
            Console.WriteLine($"Count the total bits: {bitCount}");
        }

        private int CountTotalSetBitUtil(int i)
        {
           if(i<=0)
                return 0;
           return (i%2==0?0:1)+CountTotalSetBitUtil(i%2);
        }
    }
}
