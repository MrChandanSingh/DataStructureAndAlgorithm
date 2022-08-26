using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day7
    {
        public int Search(int[] nums, int target)
        {
            if(nums.Length == 1)
            {
                if (nums[0] == target)
                    return 0;
                else
                    return -1;
            }
            int midean = nums.Length/2;
            if (nums[midean] == target)
                return midean;
            if (nums[midean] < target)
            {
                for(int i = midean+1; i <=nums.Length; i++)
                {
                    if(nums[i] == target)
                        return i;
                }
            }
            else
            {
                for (int i = 0; i < midean; i++)
                {
                    if (nums[i] == target)
                        return i;
                }
            }
            return -1;
        }

        public int[] RoateArrayRight(int[] arr,int n)
        {
            int[] nums = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                if (i + n < arr.Length)
                    nums[i] = arr[i + n];
                else
                    break;
            }

            for(int i=0; i<n; i++)
            {
                nums[i+n+1] = arr[i];
            }
            return nums;
        }

        //public int[] RotateArrayLeft(int[] arr, int n)
        //{

        //}

        
    }
}
