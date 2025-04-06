using System.Runtime.CompilerServices;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 51, 54, 42, 2, 1, 15, 54, 23, 21, 34, 432, 221 };
            Sort(0, nums);
            Console.WriteLine(string.Join(" ",nums));
        }
        //Госпожо преди време нали Ви попитах за скобите кога се слагат и сега се пробвах да го направя възможно най-сбито и същевременно работещо
        static void Sort(int count, int[] nums)
        {
            if (count == nums.Length) return;
                for (int i = 0; i < nums.Length - 1; i++)
                    if (nums[i] > nums[i + 1]) 
                        (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                count++;
            Sort(count, nums);
        }
    }
}
