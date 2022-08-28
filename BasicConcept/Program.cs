using BasicConcept.LeetCode75Days;
using BasicConcept.OopsConcept;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BasicConcept
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Day11 day11 = new Day11();
            var alice = new List<int>()
            {
                5,6,7
            };
            var bob = new List<int>()
            {
                3,6,10
            };

            var result =day11.compareTriplets(alice, bob);
            result.ForEach(x=> Console.WriteLine(x));
            Console.ReadLine();
        }

        private static async Task DoSomething1(Task res)
        {
            Console.WriteLine($"DoSomething1 milliseconds.");           
        }

        private static async Task<Task> DoSomething(int delayTime)
        {
            Console.WriteLine($"Delaying for { delayTime} milliseconds.");
            await Task.Delay(delayTime);
            Console.WriteLine($"Delay for { delayTime} milliseconds complete");
            return Task.CompletedTask;
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

        static async ValueTask<int> PP()
        {
            Console.WriteLine("PP Started");
            await Task.Delay(6000);
            Console.WriteLine("PP Completed");
            return 10;
        }
        static void PPW()
        {
            Console.WriteLine("PPW Started");
            Console.WriteLine("PPW Completed");
        }

        static void ChildMethodOfPP(int itout)
        {
            Console.WriteLine($"CHildOfPP {itout * 4}");
        }
    }


    public class BaseClass
    {
        public void Print()
        {
            Console.WriteLine("Base");
        }
    }

}
