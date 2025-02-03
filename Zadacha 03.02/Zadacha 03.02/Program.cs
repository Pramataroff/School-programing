namespace Zadacha_03._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            bool exitSwitch = true;
            Console.WriteLine("Kaufland queue manager commands:");
            Console.WriteLine("to add a person to the queue: add");
            Console.WriteLine("to remove a person from the queue: serve:");
            Console.WriteLine("to print the queue: print");
            Console.WriteLine("to exit: exit");
            Console.WriteLine("===========================================");
            while (exitSwitch)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        Add(queue);
                        break;
                    case "serve":
                        Serve(queue);
                        break;
                    case "print":
                        PrintQueue(queue);
                        break;
                    case "exit":
                        exitSwitch = false;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("===========================================");
            }
        }
        static void Add(Queue<string> queue)
        {
            Console.Write("Name of client: ");
            string name = Console.ReadLine();
            queue.Enqueue(name);
            Console.WriteLine($"{name} has joined the queue!");
        }
        static void Serve(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string served = queue.Dequeue();
                Console.WriteLine($"{served} was served");
            }
            else
            {
                Console.WriteLine("The queue is empty");
            }
        }
        static void PrintQueue(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                Console.WriteLine(string.Join(", ", queue));
            }
            else
            {
                Console.WriteLine("The queue is empty");
            }
        }
    }
}
