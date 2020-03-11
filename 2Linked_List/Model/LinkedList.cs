
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Linked_List.Model
{
    class LinkedList<T> : IEnumerable
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
            Head.Prev = null;
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
            if (Head != null)
            {
                var item = new Item<T>(data);

                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Head.Prev = null;
                    Counter -= 1;
                    return;
                }
                if (Tail.Data.Equals(data))
                {
                    Tail = Tail.Prev;
                    Tail.Next = null;
                    Counter -= 1;
                    return;
                }

                while(Counter-- != 0)
                {
                    var curr = Head.Next;
                    var prev = Head;
                    while (curr.Next != null)
                    {
                        if (curr.Data.Equals(data))
                        {
                            curr = curr.Next;
                            prev.Next = curr;
                            curr.Prev = prev;
                            Counter -= 1;
                        }
                        else
                        {
                            prev = curr;
                            curr = curr.Next;
                            curr.Prev = prev;

                        }
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {

            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
