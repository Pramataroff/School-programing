namespace word_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            Console.WriteLine($"Words count: {stack.Count}.");
            Console.WriteLine("Sentence: "+ string.Join(" ",input));

        }
    }
}
