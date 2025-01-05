namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            Stack<char> stack = new Stack<char>(chars);
            Array.Reverse(chars);
            Stack<char> reversedstack = new Stack<char>(chars);

            Print(stack, reversedstack);
        }

        static void Print(Stack<char> stack, Stack<char> reversedstack)
        {
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.Pop() != reversedstack.Pop())
                {
                    Console.WriteLine("The word is not palindrome");
                    break;
                }
                if (i == stack.Count)
                {
                    Console.WriteLine("The word is palindrome");
                }
            }
        }
    }
}
