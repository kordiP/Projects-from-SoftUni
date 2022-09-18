using System;
using System.Collections;

namespace GangOfFour.Iterator.RealWorld
{
    class MainApp
    {
        static void Main()
        {
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");
            // Create iterator
            Iterator iterator = collection.CreateIterator();
            iterator.Step = 1;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First(); !iterator.HasNext; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
            for (Item item = iterator.Last(); !iterator.HasPrevious; item = iterator.Previous())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
    class Item
    {
        private string _name;

        // Constructor
        public Item(string name)
        {
            this._name = name;
        }

        // Gets name
        public string Name
        {
            get { return _name; }
        }
    }
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        Item Last();
        Item Previous();
        bool HasNext { get; }
        bool HasPrevious { get; }
        Item CurrentItem { get; }
    }
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current;
        private int _prevCurrent;
        private int _step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            _current += _step;
            if (!HasNext)
                return _collection[_current] as Item;
            else
                return null;
        }
        public Item Last()
        {
            _prevCurrent = _collection.Count - 1;
            return _collection[_prevCurrent] as Item;
        }
        public Item Previous()
        {
            _prevCurrent -= _step;
            if (!HasPrevious)
                return _collection[_prevCurrent] as Item;
            else
                return null;
        }
        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
        // Gets current iterator item
        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }
        // Gets whether iteration is complete
        public bool HasNext
        {
            get { return _current >= _collection.Count; }
        }
        public bool HasPrevious
        {
            get { return _prevCurrent < 0; }
        }
    }
}