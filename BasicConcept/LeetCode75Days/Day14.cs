using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day14
    {

        public void HasDuplicate()
        {
            int[] arr = new int[] {1,2,1};
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i))
                {
                    Console.WriteLine("True..");
                }
                
            }

        }
    }
}
