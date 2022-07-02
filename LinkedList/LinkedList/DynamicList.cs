using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DynamicList
    {
        public Node head; //
        public Node tail; //
        public int count; //
        public DynamicList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public DynamicList(object item, object adress)
        {

        }
        public class Node //
        {
            private object element;
            private Node next;
            public object Element 
            {
                get { return element; } 
                set { element = value; }
            }
            public Node Next 
            {
                get { return next; }
                set { next = value; }
            }
            // For creating the first element 
            public Node(object element)
            {
                this.element = element;
                this.next = null;
            }
            // Not for the first time
            public Node(object element, Node prevNode)
            {
                Element = element;
                prevNode.Next = this;
            }
        }
        public void Add(object item)
        {
            // If it's empty
            if (head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }
        public void Remove(object item)
        {

        }
        public void RemoveAt(int index)
        {

        }
        public object this[int index]
        {
            get 
            {
                if (index < 0 || index > count) throw new ArgumentOutOfRangeException("ne vaji");
                Node currentNode = head;
                for (int i = 0; i < index; i++) currentNode = currentNode.Next;
                return currentNode.Element;
            }
            set 
            {
                if (index < 0 || index > count) throw new ArgumentOutOfRangeException("ne vaji");
                Node currentNode = head;
                for (int i = 0; i < index; i++) currentNode = currentNode.Next;
                currentNode.Element = value;

            }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
