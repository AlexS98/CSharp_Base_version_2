using System;

namespace Game
{
    public class Battle
    {
        public Person Character { get; set; }
        public Person Enemy { get; set; }

        public Battle(Person character, Person enemy)
        {
            Character = character;
            Enemy = enemy;
        }

        public Person Fight()
        {
            while (Character.Alive && Enemy.Alive)
            {
                Character.Hit(Enemy);
                Enemy.Hit(Character);
                Character.ShowInfo();
                Enemy.ShowInfo();
            }
            Console.ReadLine();
            return Character.Alive ? Character : Enemy;
        }
    }
}
