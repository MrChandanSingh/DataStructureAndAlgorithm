using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day17
    {
        public void ReverseString(char[] s)
        {
            // var item2 = new string[] { "c" };
            string[] item = new string[] { "A", " ", "m", "a", "n", ",", " ", "a", " ", "p", "l", "a", "n", ",", " ", "a", " ", "c", "a", "n", "a", "l", ":", " ", "P", "a", "n", "a", "m", "a" };

            foreach (var c in item)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            int n = item.Length;
            int i = 0, j = n - 1;
            
             while(i<j){            
                var temp = item[i];
                item[i] = item[j];
                item[j] = temp;
                i++;
                j--;
            }


            foreach (var temp in item)
                Console.Write(temp);

            Console.WriteLine("Expected:");
            var output = new string[] {"a", "m", "a", "n", "a", "P", " ", ":", "l", "a", "n", "a", "c", " ", "a", " ", ",", "n", "a", "l", "p", " ", "a", " ", ",", "n", "a", "m", " ", "A"};
            foreach(var c in output)
                Console.Write(c);
        }
    }
}
