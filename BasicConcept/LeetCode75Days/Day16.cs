using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day16
    {
        public int IsHappyNumber(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                var temp = number % 10;
                sum += temp * temp;
                number /= 10;
            }

            if (sum == 1)
                return 1;
          
            return -1;
        }
    }
}
