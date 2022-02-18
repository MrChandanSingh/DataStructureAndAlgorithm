using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class ArrayProblem
    {
        public void SetRowColumnZero(int[][] matrix)
        {
            int r = matrix.Length;
            int c = matrix[0].Length;
            HashSet<int> row = new HashSet<int>();
            HashSet<int> col = new HashSet<int>();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        row.Add(i);
                        col.Add(j);
                    }                       
                }
            }

            for (int i = 0;i < c; i++)
            {
                for(int j = 0;j < r; j++)
                {
                    if(row.Contains(i)|| row.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
