using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            //linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.InsertAtParticularPosition(2, 30);
            linkedlist.Display();
            Console.ReadKey();
        }
    }
}
