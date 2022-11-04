namespace BasicLinkedList
{

    public class DoublyLinkedList<T>
    {
        private DoubleLinkNode<T> header;
        private DoubleLinkNode<T> tail;
        private int count = 0;

        public DoubleLinkNode<T> Header { get => header; }

        public DoublyLinkedList()
        {
            header = new DoubleLinkNode<T>();
            tail = new DoubleLinkNode<T>();
            header.Next = tail;
            tail.Prev = header;
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
            header.Next = tail;
            tail.Prev = header;
            count = 0;
        }

        public void Insert(T item, T previousItem = default(T))
        {
            DoubleLinkNode<T> current = Find(previousItem);
            DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);
            newNode.Next = current.Next;
            newNode.Prev = current;
            current.Next = newNode;
            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;
            }
            count++;
        }

        public DoubleLinkNode<T> Find(T item)
        {
            DoubleLinkNode<T> current = header;
            if (item != null)
            {
                while (current.Element == null || current.Element.ToString() != item.ToString())
                {
                    current = current.Next;
                }
            }
            return current;
        }

        public DoubleLinkNode<T> FindLastNode()
        {
            /* DoubleLinkNode<T> current = new DoubleLinkNode<T>();
             current = header;

             while (current.Next != null)
             {
                 current = current.Next;
             }*/

            //return current;

            return tail.Prev;
        }

        public DoubleLinkNode<T> FindPrevNode(T item)
        {
            DoubleLinkNode<T> current = new DoubleLinkNode<T>();
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
            DoubleLinkNode<T> current = header;
            while (current.Next.Next != null)
            {
                returnVal += current.Next + "\n";
                current = current.Next;
            }
            return returnVal;
        }

        public string ReverseString()
        {
            string returnVal = "";

            DoubleLinkNode<T> current = tail;

            while (current.Prev.Prev != null)
            {
                returnVal += current.Prev + "\n";
                current = current.Prev;
            }

            return returnVal;
        }

        public void Remove(T item)
        {
            DoubleLinkNode<T> deletedNode = Find(item);
            deletedNode.Prev.Next = deletedNode.Next;
            if (deletedNode.Next != null)
            {
                deletedNode.Next.Prev = deletedNode.Prev;
            }
            deletedNode.Next = null;
            deletedNode.Prev = null;
            count--;
        }

    }
}
