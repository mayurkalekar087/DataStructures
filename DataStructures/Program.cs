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
            linkedlist.Add(70);
            linkedlist.Display();
            Console.WriteLine("--------------");

            //linkedlist.RemoveFirstNode();
            //linkedlist.RemoveLastNode();
            linkedlist.search(30);
            linkedlist.InsertAtParticularPosition(3, 40);
            linkedlist.Display();
            Console.ReadKey();
        }
    }
}
