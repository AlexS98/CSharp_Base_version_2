using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name:");
            string name = "Warrior";
            Person pers = new Person(name, 1);
            Person enemy1 = new Person("Enemy 1", 2);

            int[,] map = new int[10, 14];
            map[1, 1] = pers.Id;
            map[3, 3] = enemy1.Id;
            map[5, 4] = -1;

            Map map1 = new Map(10, 14);
            map1.GenerateMap();

            map1.Cells[1, 1].PersonOnCell = pers;
            map1.Cells[3, 3].PersonOnCell = enemy1;

            while (pers.Alive)
            {
                Console.Clear();
                pers.ShowInfo();
                ShowMap(map);
                Position currentPos = CurrentPersonPosition(map);
                Position wantedPos = pers.Move(map, Console.ReadKey().KeyChar.ToString());
                int wantedId = map[wantedPos.Pos1, wantedPos.Pos2];
                if (wantedId != -1 && wantedId < 2)
                    map[wantedPos.Pos1, wantedPos.Pos2] = pers.Id;
                else
                {
                    if (wantedId == -1)
                        pers.Heal();
                    else
                    {
                        Battle battle = new Battle(pers, enemy1);
                        battle.Fight();
                    }

                    if (pers.Alive)
                    {
                        map[wantedPos.Pos1, wantedPos.Pos2] = pers.Id;
                    }

                }
            }
            Console.WriteLine("Game over");
        }

        static Position CurrentPersonPosition(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    if (map[i, k] == 1)
                        return new Position(i, k);
                }
            }
            return null;
        }

        static void ShowMap(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    ToConsoleWrite("|", ConsoleColor.Green);
                    if (map[i, k] == 1)
                        ToConsoleWrite("P", ConsoleColor.Cyan);
                    else if (map[i, k] > 1)
                        ToConsoleWrite("E", ConsoleColor.Red);
                    else if (map[i, k] == -1)
                        ToConsoleWrite("♥", ConsoleColor.Red);
                    else
                        ToConsoleWrite(" ");
                }
                ToConsole("|", ConsoleColor.Green);
            }
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
