using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{
    public class DoubleLinkNode<T>
    {
        private T element;
        private DoubleLinkNode<T> prev;
        private DoubleLinkNode<T> next;

        public T Element { get => element;}
        public DoubleLinkNode<T> Prev { get => prev; set => prev = value; }
        public DoubleLinkNode<T> Next { get => next; set => next = value; }

        public DoubleLinkNode(T element)
        {
            this.element = element;
            prev = null;
            next = null;
        }

        public DoubleLinkNode()
        {
            this.element = default(T);
            prev = null;
            next = null;
        }

        public override string ToString()
        {
            return element.ToString();
        }


    }
}
