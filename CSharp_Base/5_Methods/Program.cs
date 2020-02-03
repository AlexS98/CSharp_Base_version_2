using System;

namespace _5_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson.Task1();

            int size = 0;
            do
            {
                size = ReadInteger("Enter size: ");
            }
            while (size <= 0);

            int[,] array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    array[i, k] = (i + k) % 2 == 1 ? (i + 1) * (k + 1) : 0;
                }
            }

            ShowArray(array);

        }

        static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write("{0}\t", array[i, k]);
                }
            }
        }

        static int ReadInteger(string q)
        {
            int number = 0;
            bool @continue;
            do
            {
                Console.WriteLine(q);
                string input = Console.ReadLine();
                @continue = !int.TryParse(input, out number);
            }
            while (@continue);
            return number;
        }
    }
}
