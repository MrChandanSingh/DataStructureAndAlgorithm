using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day25
    {
        public HashSet<int> result = new HashSet<int>();
        public (int num1,int num2) FindTwoSum()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            int target = 11;
            return FindTwoSum(nums, nums.Length-1, target);
        }

        private (int num1, int num2) FindTwoSum(int[] nums, int n, int target)
        {
            if (n == 0)
                return (0, 0);
            result.TryGetValue(nums[n], out int val);
           // if(val >=0)
             return (target, val);
        }
    }
}
