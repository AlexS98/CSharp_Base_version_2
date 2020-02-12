using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Person pers = new Person(name);
            Person enemy1 = new Person("Enemy 1");
            pers.ShowInfo();
            enemy1.ShowInfo();
            Battle b = new Battle(pers, enemy1);
            b.Fight();
        }
    }
}
