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

        public void HourGlass(int [,] mat)
        {
            if (mat == null)
                return;

            int r = 3;
            int c = 3;

            int max_sum = int.MaxValue;

            for(int i= 0; i < r-2; i++)
            {
                for(int j=0; j < c-2; j++)
                {
                    int sum = (mat[i, j] + mat[i, j + 1] + mat[i, j + 2]) + (mat[i + 1, j + 1]) +
                        (mat[i + 2, j] + mat[i + 2, j + 1] + mat[i + 2, j + 2]);
                    if (sum > max_sum)
                    {
                        max_sum = sum;
                    }
                }
            }

            Console.WriteLine(max_sum);
        }
    }
}
