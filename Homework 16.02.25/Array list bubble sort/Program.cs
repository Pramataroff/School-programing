using System.Collections;

namespace Array_list_bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the elements: ");
            ArrayList array = new ArrayList(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());
            int result = 0;


            for (int i = 0; i < array.Count; i++)
            {
                if (Int32.TryParse((string)array[i], out result))
                {
                    array[i] = (int.Parse((string)array[i]));
                }
                else
                {
                    int temp = array[i].ToString().Length;
                    array[i] = temp;
                }
            }

            Sorting(array);

            foreach (var VARIABLE in array)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        static void Sorting(ArrayList arrList)
        {
            for (int i = 0; i < arrList.Count; i++)
            {
                for (int j = 0; j < arrList.Count - 1; j++)
                {
                    if ((int)arrList[j] > (int)arrList[j + 1])
                    {
                        int swap = (int)arrList[j];
                        arrList[j] = arrList[j + 1];
                        arrList[j + 1] = swap;
                    }
                }
            }
        }
    }

}
