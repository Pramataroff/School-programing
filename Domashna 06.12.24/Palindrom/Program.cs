namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Stack<char> stack= new Stack<char>(chars);
            Array.Reverse(chars);
            Stack<char> reversedstack = new Stack<char>(chars);
            Print(stack,reversedstack);
        }



        static void Print(Stack<char> stack, Stack<char> reversedStack)
        {
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.Pop() != reversedStack.Pop())
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
