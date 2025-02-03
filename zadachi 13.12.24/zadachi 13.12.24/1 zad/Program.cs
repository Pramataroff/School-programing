using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace _1_zad
{
    /*Да се направи списъчна структура идваща от масив с цели числа.
     да се въведе число от клавиатурата на трето място*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, -15, 100,0, -200 };
            ArrayList arrayList = new ArrayList(numbers);
            LinkedList<int> linkedList = new LinkedList<int>(numbers);
            Stack<int> stack = new Stack<int>(numbers);

            int num = int.Parse(Console.ReadLine());

            Readyarrlist(arrayList, num);
            Readylinkedlist(linkedList, num);
            Readystack(stack, num);
            Print(arrayList);
            Print(linkedList);
            Print(stack);
        }
        static ArrayList Readyarrlist(ArrayList arrayList, int number)
        {
            arrayList.Insert(2, number);
            return arrayList;
        }
        static LinkedList<int> Readylinkedlist(LinkedList<int> linkedlist, int number)
        {
            LinkedListNode<int> node = linkedlist.First;

            int count = 0;
            while (node != null)
            {
                count++;
                if (count == 2)
                {
                    linkedlist.AddAfter(node, number);
                }
                node = node.Next;
            }
            return linkedlist;
        }
        static Stack<int> Readystack(Stack<int> stack, int number)
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(number);
            stack.Push(second);
            stack.Push(first);
            int[] list = (stack.ToArray());

            Array.Reverse(list);
            Stack<int> stack2 = new Stack<int>(list);

            return stack2;
        }

        ////static void Print(ArrayList list, LinkedList<int> linkedlist, Stack<int> stack)
        ////{
        ////    foreach (int i in list)
        ////    {
        ////        Console.Write(i + ", ");
        ////    }
        ////    Console.WriteLine();

        ////    foreach (int i in linkedlist)
        ////    {
        ////        Console.Write(i + ", ");
        ////    }
        ////    Console.WriteLine();
        ////    foreach (int i in stack)
        ////    {
        ////        Console.Write(i + ", ");
        ////    }
        ////}
        ///
        static void Print(LinkedList<int> linkedlist)
        {
            foreach (int i in linkedlist)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        static void Print(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

        }
        static void Print(Stack<int> stack)
        {
           
            foreach (int i in stack)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
