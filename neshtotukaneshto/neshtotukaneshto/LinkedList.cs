using System;

namespace neshtotukaneshto
{
    class LinkedList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode(T element, ListNode prevNode)
            {
                this.Element = element;
                prevNode.NextNode = this;
            }
            public ListNode(T element)
            {
                this.Element = element;
                this.NextNode = null;
            }
        }
        private ListNode head;
        private ListNode tail;
        public int count;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {
                ListNode newNode = new ListNode(item, tail);
                this.tail = newNode;
            }
            this.count++;
        }
        public void Insert(T item, int index)
        {
            if (index < 0 || index > count + 1) throw new ArgumentOutOfRangeException("Invalid index: " + index);
            if (count == 0)
            {
                head = new ListNode(item);
                tail = head;
             }
            else
            {
                int currentIndex = 0;
                ListNode currentNode = head;
                ListNode prevNode = null;
                ListNode itemToAdd = new ListNode(item);
                while (currentIndex < index)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
                if (index == 0)
                {
                    head = itemToAdd;
                    itemToAdd.NextNode = currentNode;
                }
                else if (index == count)
                {
                    prevNode.NextNode = itemToAdd;
                    tail = itemToAdd;
                }
                else
                {
                    prevNode.NextNode = itemToAdd;
                    itemToAdd.NextNode = currentNode;
                }
            }
            count++;
        }
        public void AddSpecial(T item)
        {
            Insert(item, 0);
        }
        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            RemoveListNode(currentNode, prevNode);
            return currentNode.Element;
        }
        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            this.count--;
            if (this.count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            else if (prevNode == null)
            {
                this.head = node.NextNode;
            }
            else
            {
                prevNode.NextNode = node.NextNode;
            }
            if (object.ReferenceEquals(this.tail, node))
            {
                this.tail = prevNode;
            }
        }
        public int Remove(T item)
        {
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            if (currentNode != null)
            {
                this.RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                return -1;
            }
        }
        public int IndexOf(T item)
        {
            int index = 0;
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }
            return -1;
        }
        public bool Contains(T item)
        {
            int index = this.IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }
            set
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.Element = value;
            }
        }

    }
}


