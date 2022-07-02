using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicListWithReverse
{
    class DynamicList
    {
        class Node
        {
            object element;
            Node next;
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
            //Ползва се когато за пръв път създаваме Node
            public Node(object element)
            {
                this.element = element;
                this.next = null;
            }
            // Ползва се когато не е за пръв път
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }
        }
        Node head = null;
        Node tail = null;
        int count = 0;
        public DynamicList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void Add(object item)
        {
            // Ако е празен...
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
        public void RemoveAt(int index) //RemoveAt
        {
            if (index >= this.count || index < 0) throw new IndexOutOfRangeException("Dumkai sa");
            //Обхождане
            int currIndex = 0;
            Node currNode = this.head;
            Node prevNode = null;
            while (currIndex < index)
            {
                prevNode = currNode;
                currNode = currNode.Next;
                currIndex++;
            }
            RemoveNode(currNode, prevNode);
        }
        public void Remove(string item)
        {
            //int currIndex = 0;
            Node newItem = new Node(item);
            Node currNode = this.head;
            Node prevNode = null;
            while (currNode != null)
            {
                if (object.Equals(currNode.Element, newItem.Element)) break;
                prevNode = currNode;
                currNode = currNode.Next;
            }
            if (currNode != null) RemoveNode(currNode, prevNode);
        }
        private void RemoveNode(Node currNode, Node prevNode)
        {
            count--;
            if (this.count == 0)
            {
                head = null;
                tail = null;
            }
            else if (prevNode == null) this.head = currNode.Next;
            else prevNode.Next = currNode.Next;
            if (object.ReferenceEquals(tail, currNode)) tail = prevNode;
        }
        public int IndexOf(object item)
        {
            int index = 0;
            Node currNode = this.head;
            while (currNode != null)
            {
                if (object.Equals(currNode.Element, item)) return index;
                currNode = currNode.Next;
                index++;
            }
            return -1;
        }
        public bool Contains(object item)
        {
            int index = this.IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                    throw new ArgumentException("Index out of range!");
                Node currN = head;
                for (int i = 0; i < index; i++)
                    currN = currN.Next;
                return currN.Element;
            }
            set
            {
                if (index >= count || index < 0)
                    throw new ArgumentException("Index out of range!");
                Node currN = head;
                for (int i = 0; i < index; i++)
                    currN = currN.Next;
                currN.Element = value;
            }
        }
        public void AddFirst(string item)
        {
            Node newItem = new Node(item);
            newItem.Next = this.head;
            this.head = newItem;
            count++;
        }
        public void Insert(int index, string item)
        {
            Node newItem = new Node(item);
            Node currNode = this.head;
            Node prevNode = null;
            int currIndex = 0;
            while (currIndex < index)
            {
                prevNode = currNode;
                currNode = currNode.Next;
                currIndex++;
            }
            prevNode.Next = newItem;
            newItem.Next = currNode;
            count++;
        }
        public void Reverse()
        {
            Node prev = null;
            Node curr = head;
            Node next = null;
            while (curr != null) // 1 2 3 4
            {                     // curr = 1
                next = curr.Next; // next = 2
                curr.Next = prev; // 1.Next = null
                prev = curr; // prev = 1
                curr = next; // curr = 2
            }                
            head = prev;
        }
        public int Count => count;
    }
}