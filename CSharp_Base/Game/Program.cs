using System;
using System.Linq;

using Game.GameObjects;
using Game.Main;
using Game.Weapons;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            BaseGame game = new BaseGame(16, 14);
            game.Start();
        }
    }
}
