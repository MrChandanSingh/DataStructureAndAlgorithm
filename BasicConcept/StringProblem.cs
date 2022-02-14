using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class StringProblem
    {
        public void PrintPermutation(string str, string ans)
        {

            //if string is empty
            if(str.Length==0)
            {
                Console.WriteLine("Given string is empty"+ans);

            }
            bool[] alpha = new bool[26];
            for(int i=0;i<str.Length;i++)
            {
                // ith character of str
                char ch = str[i];

                string newString = str.Substring(0, i) + str.Substring(i + 1);

                if(alpha[ch-'a']==false)
                  PrintPermutation(newString, ans+ch);
                alpha[ch-'a'] = true;
            }
        }
    }
}
