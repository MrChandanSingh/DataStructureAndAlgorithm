using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day21
    {
        public IList<int> GetRow(int rowIndex)
        {
            int val = 1;
            var result = new List<int>();
            for (var j = 0; j <= rowIndex; j++)
            {
                result.Add(val);
                val = val * (rowIndex - j) / (j + 1);
                if(val<0)
                {
                    val = Math.Abs(val);
                    Console.WriteLine(val);
                }
            }

            return result;
        }

        public List<int> generate(int rowIndex)
        {
            List<int> result = new List<int>();
            int[,] rows = new int[rowIndex, rowIndex];
            Console.WriteLine(rows[rowIndex - 1, rowIndex - 1]);
            for (int i = 0; i < rowIndex; i++)
            {
                
                for(int j=0;j<=i;j++)
                {
                    if (i == j || j == 0)
                        rows[i, j] = 1;
                    else
                        rows[i, j] = rows[i-1,j-1]+rows[i-1,j];
                }

               
            }
           
                
                for(int j=0;j<= rowIndex - 1;j++)
                {
                    result.Add(rows[rowIndex - 1, j]);
                }



            return result;
            
        }
    }
}
