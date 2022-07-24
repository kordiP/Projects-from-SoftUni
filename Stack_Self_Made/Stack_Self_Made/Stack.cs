using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Self_Made
{
    internal class Stack<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node NextNode { get; set; }
            public Node(T element, Node prevNode)
            {
                Element = element;
                prevNode.NextNode = this;
            }
            public Node(T element)
            {
                Element = element;
                NextNode = null;
            }
        }
        private Node head;
        private Node tail;
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Stack()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public void Push(T item)
        {
            if (Count == 0)
            {
                Node itemToAdd = new Node(item);
                head = itemToAdd;
                tail = head;
            }
            else
            {
                Node newNode = new Node(item);
                newNode.NextNode = head;
                head = newNode;
            }
            Count++;
        }
        public T Pop()
        {
            if (Count < 1) throw new ArgumentOutOfRangeException("Empty stack!");
            Node removed = head;
            head = head.NextNode;
            Count--;
            return removed.Element;
        }
        public T Peek()
        {
            return head.Element;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public bool Contains(T item)
        {
            Node currentNode = head;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode.Element.Equals(item)) return true;
                currentNode = currentNode.NextNode;
            }
            return false;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node currentNode = head;
            for (int i = 0; i < Count; i++)
            {
                array[i] = currentNode.Element;
                currentNode = currentNode.NextNode;
            }
            return array;
        }
        public T this[int index]
        {
            get 
            {
                if (index < 0 || index > Count) throw new ArgumentOutOfRangeException("Invalid index " + index + "!");
                Node currentNode = head;
                for (int i = 0; i < index; i++) currentNode = currentNode.NextNode;
                return currentNode.Element;
            }
            set
            {
                if (index < 0 || index > Count) throw new ArgumentOutOfRangeException("Invalid index " + index + "!");
                Node currentNode = head;
                for (int i = 0; i < index; i++) currentNode = currentNode.NextNode;
                currentNode.Element = value;
            }
        }
    }
}
