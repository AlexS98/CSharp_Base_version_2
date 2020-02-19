using System;
using System.Linq;

using Game.GameObjects;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string name = "Player";
            Person pers = new Character(name, 1);
            Person[] enemies = Enumerable.Range(2, 5).Select(x => new Enemy($"Enemy {x}", x)).ToArray();


            Map world = new Map(10, 14);
            world.GenerateMap();

            world.InitPerson(pers, 1, 1);
            world.InitPerson(enemies[0], 3, 3);
            world.InitPerson(enemies[1], 3, 5);
            world.InitPerson(enemies[2], 5, 3);
            world.InitPerson(enemies[3], 1, 3);
            world.InitPerson(enemies[4], 1, 4);

            while (pers.Alive)
            {
                Console.Clear();
                pers.ShowInfo();
                world.Show();
                Position wantedPos = pers.Move(Console.ReadKey().KeyChar.ToString());
            }
            Console.WriteLine("Game over");
        }
    }
}
