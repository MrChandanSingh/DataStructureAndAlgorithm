using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    internal class Day32
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int[] result = new int[2];
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (dic.ContainsKey(target - nums[i]))
                {
                    result[1] = i;
                    result[0] = dic[target - nums[i]];
                }

                dic.TryAdd(nums[i], i);
            }

            return result;
        }

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> result = new HashSet<char>();
            int prev = 0, current = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(result.Contains(s[i]))
                {
                    result.Clear();
                    result.Add(s[i]);
                    if (current>prev)
                    {
                        prev = current;
                        current = 1;
                    }
                }else
                {
                    current++;
                    result.Add(s[i]);
                }
            }
            return prev==0?current:prev;
        }
    }
}
