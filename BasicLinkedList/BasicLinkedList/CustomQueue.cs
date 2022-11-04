namespace BasicLinkedList
{
    public class CustomQueue<T>
    {
        private NoHeaderDLL<T> list;

        public CustomQueue(NoHeaderDLL<T> list)
        {
            this.list = list;
        }

        public CustomQueue()
        {
            list = new NoHeaderDLL<T>();
        }

        public void Enqueue(T item)
        {
            list.Insert(item, true);

        }

        public T Dequeue()
        {
            T returnval = list.Header.Element;

            if (!list.isEmpty())
            {
                list.Dequeue();
            }

            return returnval;
        }

        public int Count()
        {
            return list.Count();
        }

        public T Peek()
        {
            return list.Header.Element;
        }

        public bool isEmpty()
        {
            if (Count() == 0)
                return true;
            else return false;
        }

    }
}
