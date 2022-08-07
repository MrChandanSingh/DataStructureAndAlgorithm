using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day1
    {
        public int[] RunningSumArray(int[] arr)
        {
            int[] output = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                int sum = 0;
                while (j >= 0)
                {
                    sum = sum + arr[j];
                    j--;
                }
                output[i] = sum;
            }
            return output;
        }

        public int FindPivotIndex(int [] nums)
        {
            int sum = 0;
            int leftSum = 0;
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                sum = sum + nums[i];
            }

            for (int i = 0; i < length; i++)
            {
                if(leftSum == sum-leftSum-nums[i])
                    return i;
                leftSum+= nums[i];
            }
            return -1;
        }
    }
}
