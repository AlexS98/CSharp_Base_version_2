using System;
using System.Linq;

using Game.GameObjects;
using Game.Weapons;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string name = "Player";
            Character pers = new Character(name, 1);

            Random randWeapon = new Random();
            GameObject[] friends = Enumerable.Range(10, 7).Select(x => new Bot($"Friend {x}", x, true)).ToArray();
            GameObject[] enemies = Enumerable.Range(2, 8).Select(x => new Bot($"Enemy {x}", x, false)).ToArray();
            GameObject[] hearts = Enumerable.Range(0, 15).Select(x => new Heart()).ToArray();
            GameObject[] weapons = Enumerable.Range(0, 9)
                .Select(x => randWeapon.Next(0, 2) == 0
                        ? new Knife() as GameObject
                        : new Sword() as GameObject)
                .ToArray();

            Map world = new Map(16, 14);
            world.GenerateMap();

            world.InitGameObject(pers, 1, 1);

            world.SetGameObjects(enemies);
            world.SetGameObjects(friends);
            world.SetGameObjects(hearts);
            world.SetGameObjects(weapons);

            while (pers.Alive && !world.Winner())
            {
                world.Show(pers);
                Console.Write("Direction: ");
                string direct = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                pers.Move(direct);
                foreach (Bot item in enemies.Where(x => (x as Bot).Alive))
                {
                    item.Move("");
                }
                foreach (Bot item in friends.Where(x => (x as Bot).Alive))
                {
                    item.Move("");
                }
                Console.ReadKey();
            }
            world.Show(pers);
            Console.WriteLine(world.Winner() ? "Congrats!" : "Game over");
        }
    }
}
