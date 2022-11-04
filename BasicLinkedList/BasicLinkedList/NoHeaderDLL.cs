namespace BasicLinkedList
{
    public class NoHeaderDLL<T>
    {
        private DoubleLinkNode<T> header;
        private DoubleLinkNode<T> tail;
        private int count = 0;

        public DoubleLinkNode<T> Header { get => header; }
        public DoubleLinkNode<T> Tail { get => tail; }

        public NoHeaderDLL()
        {
            header = null;
            tail = header;
        }

        public int Count()
        {
            return count;
        }

        public bool isEmpty()
        {
            if (header == null)
            {
                return true;
            }
            else return false;
        }

        public void Clear()
        {
            header = null;
            tail = header;
            count = 0;
        }



        public void Insert(T item, bool isLast = false, T previousItem = default(T))
        {
            if (!isLast)
            {
                DoubleLinkNode<T> current = Find(previousItem);
                DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);
                if (current == null)
                {
                    header = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Next = current.Next;
                    newNode.Prev = current;
                    current.Next = newNode;
                    if (newNode.Next != null)
                    {
                        newNode.Next.Prev = newNode;
                    }
                    //header = newNode;
                }
            }
            else
            {
                DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);

                if (tail != null)
                {
                    newNode.Prev = tail;
                    tail.Next = newNode;
                    tail = newNode;
                }
                else
                {
                    header = newNode;
                    tail = newNode;
                }
            }
            count++;
        }

        public DoubleLinkNode<T> Find(T item)
        {
            DoubleLinkNode<T> current = header;
            if (item != null)
            {
                while (current != null && current.Element.ToString() != item.ToString())
                {
                    current = current.Next;
                }
            }
            return current;
        }

        public override string ToString()
        {
            string returnVal = "";
            DoubleLinkNode<T> current = header;
            while (current != null)
            {
                returnVal += current + "\n";
                current = current.Next;
            }
            return returnVal;
        }

        public string ReverseString()
        {
            string returnVal = "";

            DoubleLinkNode<T> current = tail;

            while (current != null)
            {
                returnVal += current + "\n";
                current = current.Prev;
            }

            return returnVal;
        }

        public void Dequeue()
        {
            if (header != null)
            {
                header = header.Next;
                if (header != null)
                {
                    header.Prev = null;
                }
                count--;
            }
        }

        public void Remove(T item, bool isLast = false)
        {
            if (!isLast)
            {
                DoubleLinkNode<T> deletedNode = Find(item);
                if (deletedNode != null)
                {
                    deletedNode.Prev.Next = deletedNode.Next;
                    if (deletedNode.Next != null)
                    {
                        deletedNode.Next.Prev = deletedNode.Prev;
                    }
                    else
                    {
                        tail = deletedNode.Prev;
                    }
                    deletedNode.Next = null;
                    deletedNode.Prev = null;
                    count--;
                }
            }
            else
            {
                if (tail != null)
                {
                    if (tail.Prev != null)
                    {
                        Tail.Prev.Next = null;
                    }
                    tail = Tail.Prev;

                    //Tail.Prev.Next = tail;
                    //tail.Prev = Tail.Prev;
                    count--;
                }
            }

        }
    }
}
