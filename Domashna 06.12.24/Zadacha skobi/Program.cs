namespace Zadacha_skobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string input = Console.ReadLine();
            char[] characters = input.ToArray();


            Stack<char> stack = new Stack<char>(characters);

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '(' || characters[i] == ')')
                {
                    stack.Push(characters[i]);
                }
            }

            if (stack.Count % 2 == 0)
            {
                Console.WriteLine("skobite sa ravni");
            }
            else
            {
                Console.WriteLine("Skobite ne sa ravni");
            }
        }
    }
}


