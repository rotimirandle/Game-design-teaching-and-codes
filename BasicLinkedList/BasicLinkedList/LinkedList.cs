using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{
    class LinkedList<T>
    {
        private Node<T> header;
        private int count = 0;

        public LinkedList(){
            header = new Node<T>();
            }

        public int Count()
        {
            return count;
        }

        public bool isEmpty()
        {
            if (header.Next == null)
            {
                return true;
            }
            else return false;
        }

        public void Clear()
        {
            header.Next = null;
            count = 0;
        }

        public void Insert(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = header.Next;
            header.Next = newNode;
            count++;
        }

        public void InsertAfter(T item, T target)
        {
            Node<T> current = new Node<T>();
            Node<T> newNode = new Node<T>(item);
            current = Find(target);
            if (current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                count++;
            }
        }

        public Node<T> Find(T item)
        {
            Node<T> current;
            current = header;

            while (current.Element.ToString() != item.ToString())
            {
                current = current.Next;
            }

            return current;
        }

        public Node<T> FindLastNode()
        {
            Node<T> current = new Node<T>();
            current = header;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public Node<T> FindPrevNode(T item)
        {
            Node<T> current = new Node<T>();
            current = header;

            while (current.Next != null && current.Next.Element.ToString() != item.ToString())
            {
                current = current.Next;
            }

            return current;
        }

        public override string ToString()
        {
            string returnVal = "";
            Node<T> current = header;
            while (current.Next != null)
            {
                returnVal += current.Next.ToString() + "\n";
                current = current.Next;
            }
            return returnVal;
        }

        public void Remove(T item) {
            Node<T> previousNode = FindPrevNode(item);
            if (previousNode != null && previousNode.Next != null)
            {
                previousNode.Next = previousNode.Next.Next;
                count--;
            }
        }



    }
}
