using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public  class Day19
    {
        public char GetFirstRecuringElement(string input)
        {
            Dictionary<char,int> result = new Dictionary<char,int>();

            foreach(char c in input)
            {
                if(result.ContainsKey(c))
                    return c;
                result.Add(c, 1);
            }

            return char.MinValue;
        }
    }
}
