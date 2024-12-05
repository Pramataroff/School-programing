namespace Zadacha_skobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string input = Console.ReadLine();
            char[] characters = input.ToArray();


            Stack<char> stack = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '(')
                {
                    stack.Push(characters[i]);
                }

                if (characters[i] == ')')
                {
                    stack2.Push(characters[i]);

                }
            }

            if (stack2.Count == stack.Count)
            {
                Console.WriteLine("The bricks are equal");
            }
            else
            {
                Console.WriteLine("The bricks are not equal");
            }
        }
    }
}


