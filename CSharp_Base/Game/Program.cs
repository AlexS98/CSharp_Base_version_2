using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Person pers = new Person(name, 1);
            Person enemy1 = new Person("Enemy 1", 2);
            pers.ShowInfo();
            enemy1.ShowInfo();
            Battle b = new Battle(pers, enemy1);
            b.Fight();
            int[,] map = new int[6, 8];
            map[1, 1] = 1;
            map[3, 3] = 2;
            ShowMap(map);

        }

        static void ShowMap(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                //for (int g = 0; g < map.GetLength(1); g++) Console.Write("__");
                //Console.WriteLine("_");
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    ToConsoleWrite("|", ConsoleColor.Green);
                    if (map[i, k] == 1)
                        ToConsoleWrite("P", ConsoleColor.Cyan);
                    else if (map[i, k] == 2)
                        ToConsoleWrite("E", ConsoleColor.Red);
                    else
                        ToConsoleWrite(" ");
                }
                ToConsole("|", ConsoleColor.Green);
            }
            //for (int g = 0; g < map.GetLength(1); g++) Console.Write("__");
            //Console.WriteLine("_");
        }
        static void ToConsoleWrite(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        static void ToConsole(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
