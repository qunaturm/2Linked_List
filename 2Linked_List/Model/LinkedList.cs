
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Linked_List.Model
{
    class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Counter { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Counter = 0;
        }

        public LinkedList(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Counter = 1;
        }

        public void Add(T data)
        {
            if (Head == null)
            {
                var item = new Item<T>(data);
                Head = Tail = item;
                Counter = 1;
            }

            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                item.Prev = Tail;
                Tail = item;
                Counter += 1;
                return;
            }
        }

        public void Del(T data)
        {

        }


    }
}
