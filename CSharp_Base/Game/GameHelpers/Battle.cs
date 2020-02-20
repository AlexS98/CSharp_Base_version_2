using System;

namespace Game
{
    public class Battle
    {
        public GamePerson Character { get; set; }
        public GamePerson Enemy { get; set; }

        public Battle(GamePerson character, GamePerson enemy)
        {
            Character = character;
            Enemy = enemy;
        }

        public GamePerson Fight()
        {
            while (Character.Alive && Enemy.Alive)
            {
                Character.Hit(Enemy);
                Enemy.Hit(Character);
                Character.ShowInfo();
                Enemy.ShowInfo();
            }
            return Character.Alive ? Character : Enemy;
        }
    }
}
