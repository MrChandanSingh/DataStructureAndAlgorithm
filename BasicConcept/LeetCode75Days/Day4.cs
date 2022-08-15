using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day4
    {

        public int DetectCycle(ListNode head)
        {
            
            Dictionary<int, int> map = new Dictionary<int, int>();
            int pos = 0;
            while (head != null)
            {
                if (map.ContainsKey(head.val))
                    return map[head.val];
                map.Add(head.val, pos);
                pos++;
                head = head.next;
            }

            return -1;
        }

        public int MaxProfit(int[] prices)
        {
            int minValue = prices[0];
            int day = 0;
            int maxProfit = 0;
            HashSet<int> minSet = new HashSet<int>();
            minSet.Add(minValue);
            for(int i = 1; i < prices.Length; i++)
            {
                if (i == prices.Length - 1)
                    break;
                if (minValue > prices[i])
                {
                    minValue = prices[i];
                    minSet.Add(minValue);
                }
            }
            foreach (int val in minSet)
            {
                day = Array.FindIndex(prices, index => index == val);


                for (int i = day + 1; i < prices.Length; i++)
                {
                    if (maxProfit < (prices[i] - val))
                    {
                        maxProfit = (prices[i] - val);
                    }
                }
            }
            return maxProfit;
        }
    }

}
