using System;

namespace _7_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human u = new Human();
            //Console.WriteLine($"{u.FirstName} {u.LastName}");
            //Human a = new Human("male", "Alex", "Svyrydenko");
            //Console.WriteLine($"{a.FirstName} {a.LastName}");

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ShowArray(myArray);
            ShowArray(SubArray(myArray, 5));
        }


        static int[] SubArray(int[] array, int n)
        {
            int size = 0;
            int[] subArray;
            foreach (var item in array)
            {
                if (item > n) size++;
            }

            if (size == 0) return new int[0];
            else
            {
                subArray = new int[size];
                int current = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > n)
                    {
                        subArray[current] = array[i];
                        current++;
                    }
                }
                return subArray;
            }
        }

        static void ShowArray(int[] array, string splitter = "; ")
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + splitter);
            }
            Console.WriteLine();
        }
    }
}
