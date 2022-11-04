using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{

    public class CustomStack<T>
    {

        private NoHeaderDLL<T> list;

        public CustomStack(NoHeaderDLL<T> list)
        {
            this.list = list;
        }

        public void Push(T item)
        {
            list.Insert(item, true);
        }

        public T Peek()
        {
            return list.Tail.Element;
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool isEmpty()
        {
            if (Count() == 0)
                return true;
            else return false;

        }

        public T Pop()
        {

            T returnVal = default(T);

            if (list.Tail != null)
            {
                returnVal = list.Tail.Element;
                list.Remove(returnVal, true);
            }

            return returnVal;
        }

        public int Count()
        {
            return list.Count();
        }
    }
}
