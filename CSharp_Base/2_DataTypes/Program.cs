using System;

namespace _2_DataTypes
{
    class Program
    {
        static int defVal = 10;

        static void Main(string[] args)
        {
            //byte b = 255; // 
            //Console.WriteLine(b);
            //Console.WriteLine($"MaxValue {short.MaxValue}, MinValue {short.MinValue}");
            //Console.WriteLine($"MaxValue {int.MaxValue}, MinValue {int.MinValue}");
            //Console.WriteLine($"MaxValue {long.MaxValue}, MinValue {long.MinValue}");
            //float fF = 2.45f;
            //float ff = 1;
            //double d = 2.45;
            //Console.WriteLine($"MaxValue {float.MaxValue}, MinValue {float.MinValue}");
            //Console.WriteLine($"MaxValue {double.MaxValue}, MinValue {double.MinValue}");
            //Console.WriteLine($"MaxValue {decimal.MaxValue}, MinValue {decimal.MinValue}");
            //decimal dec = 2.50M;

            //string l1 = "123.123" + "456" + "789";
            //Console.WriteLine($"MaxValue {ushort.MaxValue}, MinValue {ushort.MinValue}");
            //Console.WriteLine($"MaxValue {uint.MaxValue}, MinValue {uint.MinValue}");
            //Console.WriteLine($"MaxValue {ulong.MaxValue}, MinValue {ulong.MinValue}");

            int variable = 10;
            //Console.WriteLine("Start --------------------");
            //Console.WriteLine($"Before: {variable}");
            //// variable = variable + 1; // 32 - {++variable}
            //Console.WriteLine($"Increment: {++variable}");
            //// variable = variable + 1; // 32 - {variable++}
            //Console.WriteLine($"After: {variable}");
            //Console.WriteLine("End --------------------");

            Console.WriteLine($"remainder: {10 % 15}");

            bool b = true;

            b = 5 > 10;

            b = 10 > 5;

            b = 10 > 10;

            b = 10 >= 10;

            b = "qwe" == "qwe";

            b = "qwe".Equals("qwe");

            float userAge = 18;

            b = userAge >= 18 && userAge < 50;

            b = userAge < 18 || userAge >= 50;
            //             true            true
            b = userAge > 9 || userAge < 12 && userAge > 6;

            int l = 0;

            userAge = 35;

            if (userAge > 30 && userAge <= 50)
                Console.WriteLine("No no no... too small");
                Console.WriteLine("No.");

            Console.WriteLine(l);

            string defVal = "qwe";

            // kjsdnkjsdl
        }
    }
}
