using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day18
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode SwapPairs(ListNode head)
        {
            if(head == null)
                return null;
            ListNode temp = head.next;

            head.next = SwapPairs(head.next.next);
            temp.next = head;
            return temp;
        }


        public ListNode ReverseLinkedList(ListNode head)
        {
               if(head.next==null)
                return head;
           
                ListNode tmp = ReverseLinkedList(head.next);
                head.next.next = head;
                head.next = null;
                return tmp;
           
        }

        public ListNode ReverseLinkedListAtGivenNodes(ListNode head, int left, int right)
        {
            ListNode leftprev = null, cur = head;
            int i = 0;
            while(i<left-1)
            {
                leftprev = cur;
                cur = cur.next;
                i++;
            }

            ListNode prev = null;
            while(i<=right -left+1)
            {
                var tempNode = cur.next;
                cur.next = prev;
                prev = cur;
                cur=tempNode;
                i++;
            }

            leftprev.next.next = cur;
            leftprev.next = prev;

            return head;
        }
    }

}
