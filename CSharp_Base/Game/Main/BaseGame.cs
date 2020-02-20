using System;
using System.Collections.Generic;
using System.Linq;
using Game.GameObjects;
using Game.Weapons;

namespace Game.Main
{
    public class BaseGame
    {
        public Character Character { get; set; }
        public int Turn { get; set; }
        public int MapSize1 { get; set; }
        public int MapSize2 { get; set; }
        public Map World { get; set; }
        public List<GameObject> GameObjects { get; set; } = new List<GameObject>();

        public BaseGame(int mapSize1, int mapSize2)
        {
            MapSize1 = mapSize1;
            MapSize2 = mapSize2;
        }

        public Character InitPlayer()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            return new Character(name, 1);
        }

        public Map InitWorld()
        {
            Random randWeapon = new Random();
            GameObjects.AddRange(Enumerable.Range(10, 7).Select(x => new Bot($"Friend {x}", x, true)));
            GameObjects.AddRange(Enumerable.Range(2, 8).Select(x => new Bot($"Enemy {x}", x, false)));
            GameObjects.AddRange(Enumerable.Range(0, 15).Select(x => new Heart()));
            GameObjects.AddRange(Enumerable.Range(0, 9).Select(x => randWeapon.Next(0, 2) == 0
                        ? new Knife() as GameObject
                        : new Sword() as GameObject));
            Map world = new Map(MapSize1, MapSize2, Season.None);

            world.GenerateMap();
            world.InitGameObject(Character, 1, 1);
            world.SetGameObjects(GameObjects.ToArray());
            return world;
        }

        public void Start()
        {
            Character = InitPlayer();
            World = InitWorld();
            while (Character.Alive && !World.Winner())
            {
                World.Show(Character);
                Console.Write("Direction: ");
                string direct = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                Character.Move(direct);
                foreach (Bot item in GameObjects.Where(x => x is Bot b && b.Alive))
                {
                    item.Move("");
                }
                Console.ReadKey();
            }
            World.Show(Character);
            Console.WriteLine(World.Winner() ? "Congrats!" : "Game over");
        }
    }
}
