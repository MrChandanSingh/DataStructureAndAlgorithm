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

        public List<List<int>> generate(int numRows)
        {
            List<List<int>> result = new List<List<int>>();
            int[,] rows = new int[numRows,numRows];
            Console.WriteLine(rows[numRows-1,numRows-1]);
            for (int i = 0; i < numRows; i++)
            {
                
                for(int j=0;j<=i;j++)
                {
                    if (i == j || j == 0)
                        rows[i, j] = 1;
                    else
                        rows[i, j] = rows[i-1,j-1]+rows[i-1,j];
                }

               
            }
            for(int i=0;i<numRows;i++)
            {
                var row = new List<int>();
                for(int j=0;j<=i;j++)
                {
                    row.Add(rows[i,j]);
                }
                result.Add(new List<int>(row));
            }

            return result;
            
        }
    }
}
