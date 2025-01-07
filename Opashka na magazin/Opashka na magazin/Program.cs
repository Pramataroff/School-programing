namespace Opashka_na_magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command;
            while ((command = Console.ReadLine()) != "exit")
            {
                switch (command)
                {
                    case "add":
                        {
                            Console.Write("Enter name: ");
                            string adder = Console.ReadLine();
                            queue.Enqueue(adder);
                            Console.WriteLine($"{adder} is last in the queue");
                            break;
                        }
                    case "print":
                        {
                            Console.WriteLine($"current queue: {string.Join(" < ", queue)}");
                            break;
                        }
                    case "serve":
                        {
                            Console.WriteLine($"{queue.Dequeue()} was served");
                            break;
                        }
                }
            }
            Console.WriteLine("You closed the program");
        }
    }
}
