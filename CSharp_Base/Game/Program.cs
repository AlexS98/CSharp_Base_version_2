using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Player";
            Person pers = new Person(name, 1);
            Person enemy1 = new Person("Enemy 1", 2);

            Map world = new Map(10, 14);
            world.GenerateMap();

            world.InitPerson(pers, 1, 1);
            world.InitPerson(enemy1, 3, 3);

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
