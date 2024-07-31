using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTables
{
    public class HashTable<TKey, TValue> : IEnumerable<KeyValue<TKey, TValue>>
    {
        public const int InititalCapacity = 16;
        public int Count { get; private set; }
        public int Capacity { get; set; }
        public HashTable()
        {
            this.Capacity = InititalCapacity;
        }
        public HashTable(int capacity)
        {

            this.Capacity = capacity;
        }
        public void Add(TKey key, TValue value)
        {

        }
        public bool AddOrReplace(TKey key, TValue value)
        {

            return false;
        }
        public TValue Get(TKey key)
        {
            return default(TValue);
        }
        public TValue this[TKey key]
        {

        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);
            return false;
        }
        public KeyValue<TKey, TValue> Find(TKey key)
        {
            return default(KeyValue<TKey, TValue>);
        }

        public bool ContainsKey(TKey key)
        {
            return true;
        }

        public bool Remove(TKey key)
        {
            return true;
        }
        public void Clear()
        {

        }

        public IEnumerable<TKey> Keys
        {

        }
        public IEnumerable<TValue> Values
        {

        }
        public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
