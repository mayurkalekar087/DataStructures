using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class sortLinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            Node current = head, previous = null;
            while (current != null && current.data < node.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;

        }
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Element : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}

