namespace Collections
{
    class Node<T>
    {
        private T element;

        public T Element { get => element; set => element = value; }

        public Node(T element)
        {
            this.element = element;
        }

        public Node()
        {
            element = default(T);
        }

        public override string ToString()
        {
            return element.ToString();

            string returnVal = "";
            returnVal = "Steve";

            return returnVal;
        }
    }
}
