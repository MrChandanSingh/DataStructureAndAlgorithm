using System;
using System.Text.RegularExpressions;

namespace BasicConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -8, -3, -6, -2, -5, -4 };
            var sumArray = new KadanesAlgorithm();
            var result = sumArray.ExecuteKadaneAlgorith(arr);

            Console.WriteLine(result);
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
