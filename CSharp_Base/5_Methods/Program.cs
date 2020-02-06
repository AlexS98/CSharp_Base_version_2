using System;

namespace _5_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson.Task1();

            int n = ReadInteger("Enter size: ");

            //int[,] array = new int[size, size];

            //Task1(size, array);

            //ShowArray(array);

            Console.WriteLine($"Factorial {n} = {Factorial(n)}");

            Console.Write($"Fibo {n} = ");
            ShowArray(FiboNoRecursion(n));

        }

        static int Factorial(int n)
        {
            return n <= 1 ? 1 : n * Factorial(n - 1);
        }

        static int FactorialNoRecursion(int n)
        {
            int factor = 1;
            for (int i = 1; i <= n; i++)
            {
                factor = factor * i;
            }
            return factor;
        }

        static int[] FiboNoRecursion(int size)
        {
            // TODO: remove 
            if (size < 2) size = 2;
            int[] fiboArray = new int[size];
            fiboArray[0] = 1;
            fiboArray[1] = 1;

            for (int i = 2; i < size; i++)
            {
                fiboArray[i] = fiboArray[i - 1] + fiboArray[i - 2];
            }

            return fiboArray;
        }

        static void ShowArray(int[] array, string splitter = "; ")
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + splitter);
            }
            Console.WriteLine();
        }

        #region Lesson5
        static void Task1(int size, int[,] array)
        {
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    int val = 0;
                    if ((i > size - k - 1 && i < k) || (i < size - k - 1 && i > k))
                    {
                        val = 0;
                    }
                    else
                    {
                        if (k > 0)
                        {
                            val = array[i, k - 1] + 1;
                        }
                        else
                        {
                            val = 1;
                        }
                    }
                    array[i, k] = val;
                }
            }
        }

        static void ShowArray(int[,] array)
        {
            int max = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (max < array[i, k])
                    {
                        max2 = max;
                        max = array[i, k];
                    }
                    Console.Write("{0}\t", array[i, k]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Max value: {0}, second max value: {1}", max, max2);
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
        #endregion Lesson5
    }
}
