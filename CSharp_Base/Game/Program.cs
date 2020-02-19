using System;
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
            Person enemy1 = new Enemy("Enemy 1", 2);
            Person enemy2 = new Enemy("Enemy 1", 2);
            Person enemy3 = new Enemy("Enemy 1", 2);
            Person enemy4 = new Enemy("Enemy 1", 2);
            Person enemy5 = new Enemy("Enemy 1", 2);

            Map world = new Map(10, 14);
            world.GenerateMap();

            world.InitPerson(pers, 1, 1);
            world.InitPerson(enemy1, 3, 3);
            world.InitPerson(enemy2, 3, 5);
            world.InitPerson(enemy3, 5, 3);
            world.InitPerson(enemy4, 1, 3);
            world.InitPerson(enemy5, 1, 4);

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
