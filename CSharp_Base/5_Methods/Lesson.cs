using System;

namespace _5_Methods
{
    internal static class Lesson
    {
        public static void Task1()
        {
            do
            {
                int result = 0;
                do
                {
                    Console.WriteLine("Please, enter a size: ");
                }
                while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);

                int[,] array = new int[result, result];

                for (int i = 0; i < result; i++)
                {
                    for (int k = 0; k < result; k++)
                    {
                        array[i, k] = k <= i ? (i + 1) * (k + 1) : 0;
                        Console.Write("{0};\t", array[i, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Press y + [Enter] to continue...");
            }
            while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }
    }
}
