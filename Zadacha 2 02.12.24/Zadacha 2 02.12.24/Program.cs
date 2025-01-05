namespace Zadacha_2_02._12._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            List<char> chars = new List<char>();
            LinkedList<char> linkedList = new LinkedList<char>();

            foreach (char item in characters)
            {
                if (char.IsWhiteSpace(item)) continue;

                if (item == '(')
                {
                    stack.Push(item); 
                }
                else if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        chars.Add(stack.Pop());
                    }
                    stack.Pop();
                }
                else if (item == '+' || item == '-')
                {
                    while (stack.Count > 0 && (stack.Peek() == '+' || stack.Peek() == '-' || stack.Peek() == '*' || stack.Peek() == '/'))
                    {
                        chars.Add(stack.Pop());
                    }
                    stack.Push(item); 
                }
                else if (item == '*' || item == '/')
                {
                    while (stack.Count > 0 && (stack.Peek() == '*' || stack.Peek() == '/'))
                    {
                        chars.Add(stack.Pop());
                    }
                    stack.Push(item); 
                }
                else
                {
                    chars.Add(item);
                }
            }
            while (stack.Count > 0)
            {
                chars.Add(stack.Pop());
            }
            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
