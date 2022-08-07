using BasicConcept.LeetCode75Days;
using System;
using System.Text.RegularExpressions;


namespace BasicConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Day2 day2 = new Day2();
            //Console.WriteLine(day2.IsIsoMorphic("aab", "xyz"));
            //Console.WriteLine(day2.IsIsoMorphic("aab", "xxy"));
            //Console.WriteLine(day2.IsIsoMorphic("foo", "xyz"));
            //Console.WriteLine(day2.IsIsoMorphic("badc", "baba"));
            Console.WriteLine(day2.IsSubsequence("ab", "baab"));
            Console.WriteLine(day2.IsSubsequence("abc", "axybmnc"));
            Console.WriteLine(day2.IsSubsequence("aec", "abcde"));



            Console.ReadLine();
        }

        public static int SumOdd(int[] array)
        {
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                var element = array[i];
                var odd = element & 1;
                counter += (odd * element);
            }
            return counter;
        }

        public static bool MatchBrackets(string expression)
        {
            char [] chars = expression.ToCharArray();
            int opens = 0;
            foreach(char c in chars)
            {
                if (c == '(' || c=='[' || c == '}')
                {
                    opens++;
                }
                if(c == ')' || c == ']' || c == '}')
                {
                    if(opens <=0)
                    {
                        return false;
                    }
                    else
                    {
                        opens--;
                    }
                }
            }
            return opens == 0;
        }
    }


    public class BaseClass
    {
        public void Print()
        {
            Console.WriteLine("Base");
        }
    }

    public class DerivedClass: BaseClass
    {
        public void Print()
        {
            Console.WriteLine("Derived...");
        }
    }
}
