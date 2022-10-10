using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day33
    {
        public bool HasCycle(ListNode head)
        {           
            if (head == null)
            {
                return false;
            }
            ListNode hare = head;
            ListNode tortoise = head;
            while (hare!=null)
            {
                if (hare.next ==null)
                {
                    return false;
                }
                else
                {
                    hare = hare.next.next;
                    tortoise = tortoise.next;
                }
                if (tortoise == hare)
                {
                    return true;
                }
            }
            return false;
        }

        public ListNode DetectCycle(ListNode head)
        {
            Dictionary<ListNode, int> map = new Dictionary<ListNode, int>();
            int pos = 0;
            while (head != null)
            {
                if (map.ContainsKey(head))
                    return head;
                map.Add(head, pos);
                pos++;
                head = head.next;
            }

            return head;
        }
    }
}
