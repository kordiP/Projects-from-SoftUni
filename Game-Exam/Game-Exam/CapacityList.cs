using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Exam
{
    internal class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; 
        private int nextIndex = 0; 

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            int sumFirst = 0;
            int sumLast = 0;
            for (int i = startIndex; i < nextIndex; i++)
            {
                sumFirst += items[i].First;
                sumLast += items[i].Last;
            }
            startIndex++;
            nextIndex = Count + 1;
            Pair sum = new Pair(sumFirst, sumLast);
            return sum;
        }

        public Pair Sum()
        {
            int sumFirst = 0;
            int sumLast = 0;
            for (int i = 0; i < Count; i++)
            {
                sumFirst += items[i].First;
                sumLast += items[i].Last;
            }
            Pair sum = new Pair(sumFirst, sumLast);
            return sum;
        }

        public void Add(Pair item)
        {
            if (nextIndex >= items.Length)
            {
                items[Count] = SumIntervalPairs();
                Add(item);
                Count++;
            }
            else
            {
                items[nextIndex] = item;
                nextIndex++;
            }
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++) Console.WriteLine(items[i]);
        }
    }

}

