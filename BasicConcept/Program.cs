
using BasicConcept.LeetCode75Days;
using System;
using System.Threading.Tasks;

namespace BasicConcept
{
    public class RecursionTreeNode
    {
        public int val;
        public RecursionTreeNode left;
        public RecursionTreeNode right;
        public RecursionTreeNode(int val = 0, RecursionTreeNode left = null, RecursionTreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {


            
            Day35 day35 = new Day35();
            day35.CheckIfPangram("chandan");
            Console.WriteLine();



            Console.ReadLine();
        }

       

        public static RecursionTreeNode SearchNode(RecursionTreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            if (root.val >val)
                return SearchNode(root.left, val);
            else
            {
               return SearchNode(root.right, val);
            }

            return root;
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

        static async ValueTask<int> ANotherAsync()
        {
            await Task.Delay(6790);
            return 20;
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
