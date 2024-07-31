﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTables
{
    public class KeyValue<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValue(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }
        public override bool Equals(object other)
        {
            KeyValue<TKey, TValue> element
                = (KeyValue<TKey, TValue>)other;

            return Object.Equals(this.Key, element.Key)
                && Object.Equals(this.Value, element.Value);
        }

        public override int GetHashCode()
        {
            return
                this.CombineHashCodes(this.Key.GetHashCode(), this.Value.GetHashCode());
        }

        private int CombineHashCodes(int hash1, int hash2)
        {
            return
                ((hash1 << 5) + hash1) ^ hash2;
        }
        public override string ToString()
        {
            return
                $"[{this.Key} -> {this.Value}]";
        }
    }
}
