using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day28
    {
        public void WordBreak()
        {
            var inputString = "catsandog";
            var container = new List<string>() { "cats", "dog", "sand", "and", "cat" };
        
            bool isEnd = false;
            var dp = new bool[inputString.Length + 1];
            dp[inputString.Length] = true;
            for (int i = 0; i < inputString.Length-1;i++)
            {
                foreach(var w in container)
                {
                    if((i + w.Length) <= inputString.Length)
                        Console.WriteLine(inputString.Substring(i, w.Length).ToString().ToLower());

                    if((i+w.Length)<=inputString.Length && (inputString.Substring(i,w.Length).ToString().ToLower()== w.ToLower()))
                    {
                        dp[i] =dp[i+w.Length];
                        i = i+w.Length;
                    }
                    if (dp[i])
                    {
                       
                        break;
                    }
                }

            }

            Console.WriteLine(isEnd);
        }

        public void WordBreakUsingMemoization()
        {
            var container = new List<string>() { "cats", "dog", "sand", "and", "cat" };
            HashSet<string> set = new HashSet<string>(container);
            //{
            //     "cats", "dog", "sand", "and", "cat"
            //};
           
            var result= WorkBreakUsingMemoization("catsandog", set);
            Console.WriteLine(result);
        }

        private bool WorkBreakUsingMemoization(string s, HashSet<string> set)
        {
            int length = s.Length;
            if (length == 0)
                return true;
            for (int i = 1; i < length; i++)
            {
                //if (set.Contains(s.Substring(0, i)) && WorkBreakUsingMemoization(s.Substring(i).EndsWith, set))
                //{
                //    return true;
                //}
            }

            return false;
        }
    }
}
