using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
            Console.WriteLine("--------------");

            sortLinkedList sortlinkedlist = new sortLinkedList();
            sortlinkedlist.Add(56);
            sortlinkedlist.Add(30);
            sortlinkedlist.Add(40);
            sortlinkedlist.Add(70);
            sortlinkedlist.Display();
            Console.WriteLine("--------------");

            //linkedlist.RemoveFirstNode();
            //linkedlist.RemoveLastNode();
            //linkedlist.search(30);
            //linkedlist.InsertAtParticularPosition(3, 40);
            //linkedlist.Delete(40);
            //linkedlist.Display();
            //Console.ReadKey();
        }
    }
}
