namespace zadacha
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            if (chars.Length != 10)
            {
                Console.WriteLine("Invalid EGN");
                return;
            }
            List<int> nums = new List<int>();
            foreach (char item in input)
            {
                if (item == '1'|| item == '2'|| item == '3' || item =='4' || item == '5'|| item == '6'||item == '7'|| item == '8' || item == '9'|| item == '0')
                {
                    nums.Add(item - 48);
                }
            }
            if (nums.Count != 10)
            {
                Console.WriteLine("Invalid EGN");
               return;                
            }
            int lastDigit = (nums[0] * 2 + nums[1] * 4 + nums[2] * 8 + nums[3] * 5 + nums[4] * 10 + nums[5] * 9 + nums[6] * 7 + nums[7] * 3 + nums[8] * 6) % 11;

            if (lastDigit == nums[nums.Count - 1])
            {
                Console.WriteLine($"Formula-{lastDigit} == EGN-{nums[nums.Count-1]}");                
            }
            Ismalefemale(nums);
        }
        static void Ismalefemale(List<int> list)
        {
            if (list[list.Count-2] % 2 == 0)
            {
                Console.WriteLine("Muj si");
            }
            else
            {
                Console.WriteLine("Jena si");
            }
        }
    }
}
