using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.LeetCode75Days
{
    public class Day3
    {
        public ListNode MergeLinkedList(ListNode list1, ListNode list2)
        {
            if (list1 == null || list2 == null)
            {
                if (list1 == null)
                    return list2;
                else if (list2 == null)
                    return list1;
                else
                    return new ListNode();
            }

            ListNode head;
            head = list1;
            while (list2 != null)
            {
                var newNode = new ListNode(list2.val);
                ListNode current;
                if (head == null || head.val >= newNode.val)
                {
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    current = head;
                    while (current.next != null && current.next.val < newNode.val)
                    {
                        current = current.next;
                    }
                    newNode.next = current.next;
                    current.next = newNode;
                    //head = current;
                }
                list2 = list2.next;
               // head = current;
            }

            return head;
            
        }

        public ListNode ReverseLinkList(ListNode listNode)
        {
            if (listNode == null)
                return new ListNode();

            ListNode prev =null,current =listNode,next=null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public ListNode MiddleNode(ListNode head)
        {

            if (head == null)
                return null;
            int count = 0;
            ListNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            int mid = 0;

            mid = (count / 2) + 1;

            int i = 0;
            while (head != null)
            {
                i++;
                if (i == mid)
                    break;                
                head = head.next;
            }
            return head;
        }
    }

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
}
