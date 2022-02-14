using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class NumberProblem
    {

        public void HasEqualBlockFrequency(int n)
        {
            string s = Convert.ToString(n, 2);
            
            HashSet<int> set = new HashSet<int>();
            int count = 1;
            for(int i = 0; i < s.Length-1; i++)
            {
                if(s[i]==s[i+1])
                    count+= 1;
                else
                {
                    set.Add(count);
                    count = 1;
                }
                set.Add(count);
            }

            if (set.Count == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
