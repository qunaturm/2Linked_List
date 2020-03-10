using System;


namespace _2Linked_List
{
    class Program
    {
        static void Print(Model.LinkedList<int> list)
        {
            foreach (var n in list)
            {
                Console.WriteLine(n + " ");
            }

            Console.WriteLine(System.Environment.NewLine);
        }

        static void Main(string[] args)
        {

            Model.LinkedList<int> l1 = new Model.LinkedList<int>(1);

            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            Print(l1);

            //l1.Del(2);
            //Print(l1);

            l1.Del(1);
            Print(l1);
        }
    }
}
