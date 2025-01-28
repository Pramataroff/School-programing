namespace Basic_calculator
{ 
    internal class Program
    {
        public static Stack<string> stack = new Stack<string>(); 
        /*Условие
           базов калкулатор операции: събиране, изваждане, умножение и деление. стек
           да проследява историята на извикванията на методите, които извършват тези операции. Стекът
           ще съхранява информация за всяко извикване, включително вида на операцията, подадените
           числа и резултата.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers in this format: \"command \"number 1\" \"number 2\"");
            Console.WriteLine("type space between the command and the numbers ");
            Console.WriteLine("Commands:");
            Console.WriteLine("power \"number\" \"power\"");
            Console.WriteLine("add");
            Console.WriteLine("subtract");
            Console.WriteLine("divide");
            Console.WriteLine("multiply");
            Console.WriteLine("Type \"print\" to see the calculations history");
            Console.WriteLine("Type \"clear\" to clear the history");
            Console.WriteLine("To end the program type: \"end\"");
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] token = command.Split();
                switch (token[0])
                {
                    case "add":
                    {
                            Add(double.Parse(token[1]), double.Parse(token[2]));
                        break;
                    }
                    
                    case "subtract":
                    {
                        Subtract(double.Parse(token[1]), double.Parse(token[2]));
                            break;
                    }
                    
                    case "divide":
                    {
                        Divide(double.Parse(token[1]), double.Parse(token[2]));
                            break;
                    }
                    
                    case "multiply":
                    {
                        Multiply(double.Parse(token[1]), double.Parse(token[2]));
                            break;
                    }case "power":
                    {
                        Power(double.Parse(token[1]), double.Parse(token[2]));
                            break;
                    }
                    case "print":
                    {
                        Print();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("invalid command"); //Предния път ми казахте, че няма Default case 
                        break;
                    }
                }
            }
        }
        static void Add(double a, double b)
        {
            string command = $"Add: {a} + {b} = {a + b:f2}";
            Console.WriteLine($"{a} + {b} = {a + b:f2}"); 
            stack.Push(command);
            command = string.Empty;
        }
        static void Subtract(double a, double b)
        {
            string command = $"Subtract: {a} - {b} = {a - b:f2}";
            Console.WriteLine($"{a} - {b} = {a - b:f2}");
            stack.Push(command);
            command = string.Empty;
        }
        static void Multiply(double a, double b)
        {
            string command = $"Multiply: {a} * {b} = {a * b:f2}";
            Console.WriteLine($"{a} * {b} = {a * b:f2}");
            stack.Push(command);
            command = string.Empty;
        }
        static void Divide(double a, double b)
        {
            if (a != 0 && b != 0)
            {
                string command = $"Divide: {a} / {b} = {a / b:f2}";
            Console.WriteLine($"{a} / {b} = {a / b:f2}");
            stack.Push(command);
            command = string.Empty;
            }
            else
            {
                Console.WriteLine("Dividing by zero is zero again!!!");
            }
        }

        static void Power(double a, double b)
        {
            Math.Pow(a, b);
            string command = $"Power: {a} on power {b} = {Math.Pow(a, b):f2}";
            Console.WriteLine($"{a} on power {b} = {Math.Pow(a, b):f2}");
            stack.Push(command);
        }
        static void Print()
        {
            Console.WriteLine("History");
            foreach (string VARIABLE in stack)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
