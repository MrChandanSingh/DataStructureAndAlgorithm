using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day9
    {
        public void CheckNumberIsPalindrome()
        {
            int number = 1331;
            List<int> list = new List<int>();
            while(number > 0)
            {
                int rem = number % 10;
                number /= 10;
                list.Add(rem);
            }
            int count = list.Count-1;
            for(int i=0;i<count;i++)
            {
                if (list[i] == list[count-i])
                    continue;
                else
                {
                    Console.WriteLine("No a Palindrome");
                    break;
                }
            }
            Console.WriteLine("Yes, it is palindrome");
        }
    }
}
