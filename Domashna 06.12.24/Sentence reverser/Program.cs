namespace Sentence_reverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split().ToArray();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                string word = string.Join("", wordChars);
                stack.Push(word);
            }
            Console.WriteLine("Sentence before operations: "+string.Join(" ",words));
            string[] finalsentance = stack.ToArray();
            Console.WriteLine("Reversed sentence: " + string.Join(" ", finalsentance));
            Array.Reverse(finalsentance);
            Console.WriteLine("Reversed words + sentence backwards: "+string.Join(" ",finalsentance));

        }
    }
}
