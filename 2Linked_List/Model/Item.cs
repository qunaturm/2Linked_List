
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Linked_List.Model
{
    public class Item<T>
    {
        private T data = default(T);

        public T Data
        {
            get => data;
            set
            {
                if (value != null) data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }

        public Item(T Data)
        {
            this.Data = Data;
        }
        public Item<T> Next { get; set; }
        public Item<T> Prev { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
