using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{

    public class Node
    {
        public Node next;
        public Node tail; 
        public int _data;

        public Node(int data)
        {
            _data = data;
            next = null;
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
}
