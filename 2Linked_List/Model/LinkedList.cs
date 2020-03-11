
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

        public LinkedList(){ Clear(); }

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

        public void AddToHead(T data)
        {
            if (Head == null)
            {
                var item = new Item<T>(data);
                Head = Tail = item;
                Head.Prev = Tail.Next = null;
                Counter = 1;
                return;
            }
            else
            {
                var item = new Item<T>(data);
                Head.Prev = item;
                item.Next = Head;
                Head = item;
                Counter += 1;
                return;
            }
        }

        public void AddAfterItem(T val, T data) //val - элемент поле к-го вставляем, data - что вставляем
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                if (Tail == item)
                {
                    Add(data);
                    return;
                }
                if (Head == item)
                {
                    AddToHead(data);
                    return;
                }
                var curr = Head.Next;
                var prev = Head;
                while(curr != null)
                {
                    if (curr.Data.Equals(val))
                    {
                        prev.Next = item;
                        item.Prev = prev;
                        item.Next = curr;
                        curr.Prev = item;
                        return;
                    }
                    else
                    {
                        if(prev == Head)
                        {
                            prev = curr;
                            curr = curr.Next;
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
                            return;
                        }
                        else
                        {
                            prev = curr;
                            curr = curr.Next;
                            curr.Prev = prev;

                        }
                        //throw new ItemNotFound();
                    }
                }
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Counter = 0;
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
