using System;

namespace _3_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctOperator = true;
            //do
            //{
            //    Console.WriteLine("Enter operation");
            //    string v = Console.ReadLine();
            //    correctOperator = true;
            //    switch (v)
            //    {
            //        case "+":
            //            Console.WriteLine($"Find {v}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"Find {v}");
            //            break;
            //        case "/":
            //            Console.WriteLine($"Find {v}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"Find {v}");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong operation!");
            //            correctOperator = false;
            //            break;
            //    }
            //}
            //while (!correctOperator);


            //for (int i = -10; i <= 10; i = i + 2)
            //{
            //    Console.WriteLine($"Value: {i}");
            //}

            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = i;
                    Console.WriteLine("First " + array[temp]);
                    array[i] = i++;
                    Console.WriteLine("Second " + array[temp]);
                    i--;
                }
            }
            catch (Exception) { }




        }


        void T()
        {
            Console.WriteLine("Make a bet, please:");
            decimal bet = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please, enter a number from 0 to 20:");
            int number = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int randNumber = rand.Next(21);
            int defference1 = number - randNumber;
            int defference2 = randNumber - number;

            if (number == randNumber)
            {
                decimal winning = bet * 2;
                Console.WriteLine($"YAy!!! You won!!! Your winning is {winning} !!!");
            }
            else if (defference1 < 3 || defference2 < 3)
            {
                decimal winning = bet * 0.75m;
                Console.WriteLine($"Your winning is {winning} ! Not bad!");
            }
            else if (defference1 < 7 && defference1 > 3 || defference2 < 7 && defference2 > 3)
            {
                decimal winning = bet / 3;
                Console.WriteLine($"Your winning is {winning} ! Could be worse!");
            }
            else Console.WriteLine("Ooops, you lost everything...");

        }
    }
}
