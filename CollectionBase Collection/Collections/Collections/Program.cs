using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {

            public class Collection : CollectionBase
        {
            public void Add(Object item)
            {
                InnerList.Add(item);
            }

            public void Remove(Object item)
            {
                InnerList.Remove(item);
            }

            public int Count()
            {
                return InnerList.Count;
            }

            public void Clear()
            {
                InnerList.Clear();
            }

            public bool Contains(Object o)
            {
                bool returnVal = false;

                foreach (Object temp in InnerList)
                {
                    //if (temp.ToString() == o.ToString())
                    if (temp.Equals(o))
                    {
                        returnVal = true;
                    }
                }

                return returnVal;
            }

            public int IndexOf(Object o)
            {
                int returnVal = 0, k = 0;

                foreach (Object item in InnerList)
                {
                    if (item.Equals(o))
                    {
                        returnVal = k;
                    }
                    k++;
                }

                return returnVal;
            }

            public void ListItems()
            {
                foreach (Object o in InnerList)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }

        static void Main(string[] args)
        {

            Collection collection = new Collection();

            collection.Add(5);
            Console.WriteLine(collection.Contains(5));
            Console.WriteLine(collection.IndexOf(5));
            collection.Add("Cheese");
            collection.Add("Steve");
            collection.Add(new int[10]);
            collection.ListItems();
            collection.Remove("Donald Trump");



        }
    }
}
