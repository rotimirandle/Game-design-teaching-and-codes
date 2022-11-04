namespace BasicLinkedList
{
    public class ListIterator<T>
    {
        private DoubleLinkNode<T> current;
        private DoubleLinkNode<T> prev;
        private DoublyLinkedList<T> list;

        public DoubleLinkNode<T> Current { get => current; }

        public ListIterator(DoublyLinkedList<T> list)
        {
            this.list = list;
            current = list.Header.Next;
            prev = list.Header;
        }

        public void Back()
        {
            current = current.Prev;
            prev = current.Prev;
        }


        public void Forward()
        {
            prev = current;
            current = current.Next;
        }

        public void InsertAfter(T item)
        {
            DoubleLinkNode<T> newNode = new DoubleLinkNode<T>(item);
            newNode.Next = current.Next;
            current.Next = newNode;
            Forward();

        }

        public void Reset()
        {
            current = list.Header.Next;
            prev = list.Header;
        }

        public bool IsEnd()
        {
            if (current.Next.Next == null)
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
        }
        public void Remove()
        {
            prev.Next = current.Next;
            current = current.Next;
        }
    }
}
