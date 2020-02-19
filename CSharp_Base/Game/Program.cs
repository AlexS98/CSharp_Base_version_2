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
            Character pers = new Character(name, 1);

            Person[] enemies = Enumerable.Range(2, 5).Select(x => new Enemy($"Enemy {x}", x)).ToArray();
            Heart[] hearts = Enumerable.Range(2, 5).Select(x => new Heart()).ToArray();


            Map world = new Map(10, 14);
            world.GenerateMap();

            world.InitGameObject(pers, 1, 1);

            foreach (var item in enemies)
            {
                int pos1, pos2;
                do
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    pos1 = rand1.Next(0, world.WorldHeight);
                    pos2 = rand1.Next(0, world.WorldWidth);
                } while (!world.InitGameObject(item, pos1, pos2));

            }

            foreach (var item in hearts)
            {
                int pos1, pos2;
                do
                {
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    pos1 = rand1.Next(0, world.WorldHeight);
                    pos2 = rand1.Next(0, world.WorldWidth);
                } while (!world.InitGameObject(item, pos1, pos2));

            }

            while (pers.Alive && !world.Winner(pers))
            {
                pers.ShowInfo();
                world.Show();
                pers.Move(Console.ReadKey().KeyChar.ToString());
                foreach (Enemy item in enemies)
                {
                    world.Refresh();
                    item.Move("");
                }
            }
            world.Show();
            Console.WriteLine(world.Winner(pers) ? "Congrats!" : "Game over");
        }
    }
}
