namespace BasicLinkedList
{


    public class Node<T>
    {
        private T element;
        private Node<T> next;

        public T Element { get => element; }
        public Node<T> Next { get => next; set => next = value; }

        public Node(T element)
        {
            this.element = element;
            next = null;
        }

        public Node()
        {
            element = default(T);
            next = null;
        }

        public override string ToString()
        {
            return element.ToString();
        }
    }
}
