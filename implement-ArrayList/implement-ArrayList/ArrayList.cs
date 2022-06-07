using System;
using System.Linq;

namespace implement_ArrayList
{
    internal class ArrayList<T>
    {
        // remove index, remove value
        private const int Intitial_size = 1;
        private T[] items;
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public ArrayList()
        {
            this.items = new T[Intitial_size];
        }
        public T this[int index]
        {
            get
            {
                if (this.items.Length < Count) throw new ArgumentOutOfRangeException();
                return items[index];
            }
            set
            {
                if (this.items.Length < Count) throw new ArgumentOutOfRangeException();
                items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Expand();
            }
            this.items[this.Count++] = item;
        }
        private void Expand()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public T RemoveAt(int index)
        {
            if (index > this.Count) throw new ArgumentOutOfRangeException();
            T element = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return element;
        }
        public void RemoveItem(T item)
        {
            if (!this.items.Contains(item)) throw new ArgumentOutOfRangeException();
            for (int i = 0; i < this.items.Length; i++)
                if (this.items[i].Equals(item))
                {
                    this.items[i] = default(T);
                    this.Shift(i);
                    this.Count--;
                    if (this.Count <= this.items.Length / 4) this.Shrink();
                }
        }
        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i <= this.items.Length - 2; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[items.Length - 1] = default(T);
        }
        public void Print()
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                Console.Write(" " + items[i]);
            }
            Console.WriteLine();
        }
    }
}
