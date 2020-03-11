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

        //неработающий и поэтому закомментированный кусок shit
        //static void SetItemsFromKeyboard(Model.LinkedList<int> list, int q) //q - количество элементов, которые надо добавить в список
        //{
        //    for (int i = 0; i < q; ++i)
        //    {
        //        Console.WriteLine("give me a numeral you fucking asshole!");
        //        int data = Console.Read();
        //        list.Add(data);
        //        Console.WriteLine(System.Environment.NewLine);

        //    }
        //}

        static void Main(string[] args)
        {

            Model.LinkedList<int> l1 = new Model.LinkedList<int>(0);

            l1.Add(1);
            l1.Add(2);
            Console.WriteLine("Creating list with 3 numerals: 0, 1, 2.");
            Print(l1);
            l1.AddToHead(0);
            l1.AddAfterItem(0, 10);
            Console.WriteLine("Add 0 to head and 10 after 0.");
            Print(l1);

            l1.Del(2);
            Console.WriteLine("Del 2.");
            Print(l1);

            Console.ReadLine();
        }
    }
}
