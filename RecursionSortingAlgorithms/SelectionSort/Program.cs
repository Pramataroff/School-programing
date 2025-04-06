namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 51, 54, 42, 2, 1, 15, 54, 23, 21, 34, 432, 221 };
            Sort(0, nums);
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Sort(int count, int[] nums)
        {
            if (count == nums.Length - 1) return;
            int k = count;
            for (int i = count + 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[k])
                {
                    k = i;
                }
            }
            (nums[k], nums[count]) = (nums[count], nums[k]);
            count++;
            Sort(count,nums);
        }
    }
}
