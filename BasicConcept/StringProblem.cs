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

        public void CheckStringsAreRotation(string input1, string input2)
        {
            if(input1.Length== input2.Length &&
                (input1+input2).IndexOf(input1)!=-1)
            {
                Console.WriteLine("Strings are rotation of each other.");
            }
            else
            {
                Console.WriteLine("Strings are not rotation of each other.");
            }
        }
    }
}
