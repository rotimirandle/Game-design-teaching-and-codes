namespace BasicLinkedList
{
    public class NHListIterator<T>
    {
        private DoubleLinkNode<T> current;
        private DoubleLinkNode<T> prev;
        private NoHeaderDLL<T> list;

        public DoubleLinkNode<T> Current { get => current; }

        public NHListIterator(NoHeaderDLL<T> list)
        {
            this.list = list;
            current = list.Header;
            prev = null;
        }

        public void Back()
        {
            if (current != null)
            {
                current = current.Prev;
                if (current != null)
                {
                    prev = current.Prev;
                }
            }
        }


        public void Forward()
        {
            prev = current;
            if (current != null)
            {
                current = current.Next;
            }
        }

        public void InsertAfter(T item)
        {
            DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);
            if (current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                Forward();
            }

        }

        public void Reset()
        {
            current = list.Header;
            prev = null;
        }

        public bool IsEnd()
        {
            if (current == null || current.Next == null)
                return true;
            else return false;
        }

        public void InsertBefore(T item)
        {
            DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);

            if (current != list.Header)
            {
                newNode.Next = prev.Next;
                prev.Next = newNode;
                current = newNode;
            }
            else
            {
                newNode.Next = current;
                prev = newNode.Prev;
                current = newNode;
            }
        }
        public void Remove()
        {
            if (prev != null)
            {
                prev.Next = current.Next;
                current = current.Next;
            }

        }
    }
}
