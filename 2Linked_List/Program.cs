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
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            l1.Add(6);
            l1.Add(7);

            Print(l1);

            l1.Del(0);
            l1.Del(7);
            //l1.Del(11); //вылезет пользовательский эксепшн //должен вылезти, но я тупая
            l1.Del(5);

            Print(l1);

            Console.ReadLine();
        }
    }
}
