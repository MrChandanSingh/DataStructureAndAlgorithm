using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{

    public class Node
    {
        public Node Next { get; set; }
        public int _data { get; }

        public Node(int data)
        {
            _data = data;
            Next = null;
        }

        
    }


    public class DoubleLinkedList
    {
        internal DoubleNode head;

        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DoubleNode doubleNode = new DoubleNode();
            doubleNode.data = data;
            doubleNode._next = doubleLinkedList.head;
            doubleNode._prev = null;
            if(doubleLinkedList.head != null)
            {
                doubleLinkedList.head._prev = doubleNode;
            }

            doubleLinkedList.head = doubleNode;
        }

        internal void InsertAtEnd(DoubleLinkedList doubleLinkedList, int data)
        {
            DoubleNode newNode = new DoubleNode();
            newNode.data = data;
            if(doubleLinkedList.head == null)
            {
                newNode._prev = null;
                doubleLinkedList.head = newNode;
                return;
            }

            DoubleNode lastNode = GetLastNode(doubleLinkedList);
            lastNode._next = newNode;
            lastNode._prev = lastNode;
        }

        internal void InsertAfter(DoubleNode prevNode, int data)
        {
            if (prevNode == null)
                return;
            DoubleNode newNode = new DoubleNode();
            newNode.data = data;
            newNode._prev = prevNode;
            prevNode._next = newNode;
            if(newNode._next != null)
            {
                newNode._next._prev = prevNode._prev;
            }
        }

        internal void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, int key)
        {
            DoubleNode temp = doubleLinkedList.head;
            while (temp != null)
            {
                if(temp.data == key)
                {
                    temp = temp._next;
                }

            }
        }

        internal void Read(DoubleNode doubleNode)
        {
            while(doubleNode != null)
            {
                Console.WriteLine(doubleNode.data);
                doubleNode = doubleNode._next;
            }
        }

        private DoubleNode GetLastNode(DoubleLinkedList doubleLinkedList)
        {
            DoubleNode tempNode = doubleLinkedList.head;
            while(tempNode != null)
            {
                tempNode = tempNode._next;
            }
            return tempNode;
        }
    }
    public class DoubleNode
    {
        internal DoubleNode _prev;
        internal DoubleNode _next;
        internal int data;

        
    }

    public class LinkedListProbelmSet
    {

        public Node GetSumOfTwoLinkedListsIntoNewLinkedList(Node node1,Node node2)
        {
            Node outputNode = null;
            bool carry = false;
            int sum = 0;
            while(node1 != null || node2!=null)
            {
               if(node1!=null)
                {
                    sum += node1._data;
                }
               if(node2!=null)
                {
                    sum += node2._data;
                }

               if(carry)
                {
                    sum += 1;
                    carry = false;
                }
               if(sum >=10)
                {
                    sum -= sum;
                    carry = true;
                }

               if(outputNode == null)
                {
                    outputNode = new Node(sum);
                }
               else
                {
                    var temp = outputNode;
                    while(temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = new Node(sum);
                }

               node1 = node1!=null ? node1.Next : null;
               node2 = node2!=null ? node2.Next : null;
            }



            return outputNode;
        }
    }


    public class SingleLinkedListNode<T>
    {
        
        private SingleLinkedListNode<T>? Head { get; set; }

        //public SingleLinkedListNode<T> AddFirst(T data)
        //{
        //    var newListElement = new SingleLinkedListNode<T>
        //    {
        //        Head =
        //    }
        //}
    }

    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }

        public T Data { get; }

        public SinglyLinkedListNode<T>? Next { get; set; }
    }
}
