using System;
using System.Collections;

namespace Collections
{
    public class Collection<T>
    {

        private ArrayList InnerList = new ArrayList();

        public void Add(T item)
        {
            InnerList.Add(item);
        }

        public void Remove(T item)
        {
            InnerList.Remove(item);
        }

        public int Count()
        {
            return InnerList.Count;
        }

        public bool Contains(T item)
        {
            return InnerList.Contains(item);
        }

        public void Clear()
        {
            InnerList.Clear();
        }

        public int IndexOf(T item)
        {
            return InnerList.IndexOf(item);
        }

        public override string ToString()
        {
            string returnVal = "";
            foreach (T temp in InnerList)
            {
                returnVal += temp.ToString() + Environment.NewLine;
            }
            return returnVal;
        }
    }
}
