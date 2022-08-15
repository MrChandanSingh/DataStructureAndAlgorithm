using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day5
    {
        public int GetLongestPalindrome(string s)
        {

            int[] count = new int[128];
            foreach(var c in s)
                count[c]++;

            int ans = 0;
            foreach(int v in count)
            {
                ans += v / 2 * 2;
                if (ans % 2 == 0 && v % 2 == 1)
                    ans++;
            }
            return ans;
        }
    }
}
