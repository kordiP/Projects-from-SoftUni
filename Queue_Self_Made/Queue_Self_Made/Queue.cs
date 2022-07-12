using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Self_Made
{
    internal class Queue<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node nextNode { get; set; }
            public Node(T element, Node prevNode)
            {
                this.Element = element;
                prevNode.nextNode = this;
            }
            public Node(T element)
            {
                Element = element;
                this.nextNode = null;
            }
        }
        private Node head = null;
        private Node tail = null;
        private int count = 0;
        public int Count 
        {
            get { return count; }
            set { count = value; } 
        }
        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                Node itemToAdd = new Node(item);
                head = itemToAdd;
                tail = head;
            }
            else
            {
                Node itemToAdd = new Node(item, tail);
                tail = itemToAdd;
            }
            Count++;
        }
        public T Dequeue()
        {
            if (Count < 1) throw new ArgumentOutOfRangeException("Empty queue!");
            Node removed = head;
            head = head.nextNode;
            Count--;
            return head.Element;
        }
        public T Peek()
        {
            return head.Element;
        }
        public void Clear()
        {
            head = null;
            tail = head;
            Count = 0;
        }
        public bool Contains(T item)
        {
            Node curr = head;
            for (int i = 0; i < Count; i++)
            {
                curr = curr.nextNode;
                if (curr.Equals(item)) return true;
            }
            return false;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > Count) throw new ArgumentOutOfRangeException("Invalid index " + index);
                Node curr = head;
                for (int i = 0; i < index; i++) curr = curr.nextNode;
                return curr.Element;
            }
            set
            {
                if (index < 0 || index > Count) throw new ArgumentOutOfRangeException("Invalid index " + index);
                Node curr = head;
                for (int i = 0; i < index; i++) curr = curr.nextNode;
                curr.Element = value;
            }
        }
    }
}
