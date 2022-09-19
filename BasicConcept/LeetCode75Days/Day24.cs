using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day24
    {
        double result = 0;
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;

            if (n < 0)
            {
                x = 1 / x;
                return (n % 2 == 0) ? MyPow(x * x, -(n / 2)) : x * MyPow(x * x, -(n / 2));
            }
            else
                return (n % 2 == 0) ? MyPow(x * x, (n / 2)) : x * MyPow(x * x, (n /2));
        }


        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }

            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
                
        }

        //string kth;
        public int KthGrammar(int n, int k)
        {
            if (n == 1)
                return 0;
            int parent = KthGrammar(n - 1, (k + 1) / 2);
            if (k % 2 == 0)
                return parent == 1 ? 0 : 1;
            else
                return parent;

        }
    }
}
