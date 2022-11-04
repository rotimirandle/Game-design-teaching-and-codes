using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Program
    {

        static void Swap<T>(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Swap(ref num1, ref num2);
            Console.WriteLine(num1 + " " + num2);

            Collection<int> intList = new Collection<int>();
            intList.Add(5);
            intList.Add(10);
            intList.Add(15);
            intList.Remove(10);
            Console.WriteLine("Index of 15 is " + intList.IndexOf(15));
            Console.WriteLine("Contains 10? " + intList.Contains(10));

            Console.WriteLine(intList.ToString());
            Console.WriteLine("Number of items: " + intList.Count());
            intList.Clear();

            Console.WriteLine("List: " + intList.ToString());

            Collection<Node<object>> collection = new Collection<Node<object>>();
            collection.Add(new Node<object>(5));

        }
    }
}
