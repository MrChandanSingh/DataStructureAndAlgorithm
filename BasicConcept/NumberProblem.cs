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


        public void SumExactly2Bits(int number)
        {
            int sum = 0;
            for (int i = 1;1<<i<number;i++)
            {
                for(int j=0;j<i;j++)
                {
                    int num = (1 << i) + (1 << j);
                    if (num < number)
                        sum += sum + number;
                }
            }

            Console.WriteLine(sum);
        }

        public void CheckTwoNumbersAreOppsiteSign(int n1, int n2)
        {
            var isSame = (n1 ^ n2) < 0;
            Console.WriteLine($"The given two numbers {n1} & {n2} are same sign: {isSame}");
        }
    }
}
