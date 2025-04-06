namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 51, 54, 42, 2, 1, 15, 54, 23, 21, 34, 432, 221 };
            Sort(nums, 0);
            Console.WriteLine(string.Join(" ,", nums));
        }

        static void Sort(int[] nums, int n)
        {
            int i = n;
            if (n == nums.Length - 1) return;
            for (int j = i + 1; j > 0; j--) 
                if (nums[j - 1] > nums[j]) (nums[j], nums[j-1]) = (nums[j-1], nums[j]);
            Sort(nums, n + 1);
        }
    }
}