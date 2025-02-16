namespace Linked_list_bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            BubbleSort(linkedList);
            Console.WriteLine($"Bubble Sorted List: "+ string.Join(", ",linkedList));
        }
        static void BubbleSort(LinkedList<int> list)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                LinkedListNode<int> current = list.First;

                while (current != null && current.Next != null)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            }
        }
    }
}