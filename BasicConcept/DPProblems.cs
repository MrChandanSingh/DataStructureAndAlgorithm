using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class DPProblems
    {
        public void LongestIncreasingSubSequence(int[] arr)
        {
            int[,] dp = new int[arr.Length,arr.Length];
            for (int i = 0; i < arr.Length+1; i++)
            {
                for(int j = 0; j < arr.Length+1; j++)
                {
                    dp[i, j] = -1;
                }
            }

            for(int i=0;i<arr.Length+1;i++)
            {
                for(int j=0;j<arr.Length+1;j++)
                {
                    if(i==0|| j==0)
                    {
                        dp[i,j] = 0;
                    }

                    else if(arr[j-1]==0)
                    {
                        if (i == arr.Length - 1)
                        { }
                    }
                }
            }
        }
    }
}
