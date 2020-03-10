using System;


namespace _2Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.LinkedList<int> l1 = new Model.LinkedList<int>();
            l1.Add(3);
            Console.WriteLine(l1.Head);
            Console.WriteLine(l1.Tail);
            Console.ReadLine();
        }
    }
}
