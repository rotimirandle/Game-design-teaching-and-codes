using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            LinkedList<int> intList = new LinkedList<int>();
            Console.WriteLine("Size of List: " + intList.Count());
            intList.Insert(100);
            intList.Insert(200);
            intList.InsertAfter(150, 200);
            intList.InsertAfter(110, 150);
            Console.WriteLine(intList);
            Console.WriteLine("Size of List: " + intList.Count());
            Console.WriteLine("Trying to remove...");
            intList.Remove(1000);
            Console.WriteLine(intList);
            Console.WriteLine("Size of List: " + intList.Count());
            Console.WriteLine("Trying to remove...");
            intList.Remove(110);
            Console.WriteLine(intList);
            Console.WriteLine("Size of List: " + intList.Count());
            Console.WriteLine("Tail: " + intList.FindLastNode());
            if (intList.Find(100) != null)
            {
                Console.WriteLine("100 exists");
            }
            Console.WriteLine(intList.FindPrevNode(100));
            */

            // DoublyLinkedList<string> dialogue = new DoublyLinkedList<string>();
            /*NoHeaderDLL<string> dialogue = new NoHeaderDLL<string>();
            dialogue.Insert("Hello");
            dialogue.Insert("My name is Adam", true);
            dialogue.Insert("I am NOT a furry", true);
            dialogue.Insert("UwU", true);
           Console.WriteLine(dialogue);
            dialogue.Remove("", true);
            Console.WriteLine(dialogue);

            CustomStack<string> stack = new CustomStack<string>(dialogue);
            stack.Push("Stack test");
            Console.WriteLine(stack.Peek());
            while (!stack.isEmpty())
            {
                Console.WriteLine("Popping: " + stack.Pop() + " count is " + stack.Count());
            }*/

            CustomQueue<string> queue = new CustomQueue<string>();
            queue.Enqueue("Helped a man");
            queue.Enqueue("Pushed a cat into a well");
            queue.Enqueue("Slept with the furry o.O");
            queue.Enqueue("Killed yourself");
            Console.WriteLine("Decisions:");
            while (!queue.isEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }

            /*
            ListIterator<string> dialogueMover = new ListIterator<string>(dialogue);
            Console.WriteLine(dialogueMover.Current);
            string input = Console.ReadLine();
            while (dialogueMover.Current.Element != null)
            {
            switch (Convert.ToInt32(input))
                {
                    case 0:
                        dialogueMover.Forward();
                        break;
                    case 1:
                        dialogueMover.Back();
                        break;
                }
                if (dialogueMover.Current.Element != null){
                    Console.WriteLine(dialogueMover.Current);
                    input = Console.ReadLine();
                }
            }
            */


        }
    }
}
