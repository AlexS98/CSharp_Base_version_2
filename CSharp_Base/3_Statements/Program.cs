using System;

namespace _3_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctOperator = true;
            do
            {
                Console.WriteLine("Enter operation");
                string v = Console.ReadLine();
                correctOperator = true;
                switch (v)
                {
                    case "+":
                        Console.WriteLine($"Find {v}");
                        break;
                    case "-":
                        Console.WriteLine($"Find {v}");
                        break;
                    case "/":
                        Console.WriteLine($"Find {v}");
                        break;
                    case "*":
                        Console.WriteLine($"Find {v}");
                        break;
                    default:
                        Console.WriteLine("Wrong operation!");
                        correctOperator = false;
                        break;
                }
            }
            while (!correctOperator);
        }
    }
}
