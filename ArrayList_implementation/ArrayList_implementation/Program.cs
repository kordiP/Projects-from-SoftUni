using System;

namespace ArrayList_implementation
{
    class Program
    {
        public class ArrayList<T>
        {
            private const int Initial_Capacity = 2;
            private T[] items;
            public ArrayList()
            {
                this.items = new T[Initial_Capacity];
            }
            public int Count { get; private set; }

            //индексатор, за да се достъпва масивът по индекс
            public T this[int index]
            {
                get
                {
                    if (index >= this.Count)
                    {
                        //грешка
                        throw new ArgumentOutOfRangeException("йхйх");
                    }
                    return this.items[index];
                }
                set
                {
                    if (index >= this.Count)
                    {
                        //грешка
                        throw new ArgumentOutOfRangeException();
                    }
                    this.items[index] = value;
                }
            }
            private void Resize()
            {
                T[] copy = new T[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }
            public void Add(T item)
            {
                if (this.Count == this.items.Length)
                {
                    this.Resize();
                }
                this.items[this.Count++] = item;
            }
            private void Shift(int index)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.items[i] = this.items[i + 1];
                }
            }

            //свива масива наполовина, за да се пести памет
            private void Shrink()
            {
                T[] copy = new T[this.items.Length / 2];
                for (int i = 0; i < this.Count; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }
            public T RemoveAt(int index)
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
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
        }
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(5);
            list.Add(7);
            Console.WriteLine("{0}  {1}", list[0], list[1]);
            list[0] = list[0] + 1;
            list[1] = list[1] + 1;
            Console.WriteLine("{0}  {1}", list[0], list[1]);
            list.Add(10);
            list.Add(12);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            Console.WriteLine();
            Console.WriteLine("Ти изтриваш елемента {0} ", list.RemoveAt(0));
            Console.WriteLine("След изтриването на първия елемент:");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }
    }

  
    }
