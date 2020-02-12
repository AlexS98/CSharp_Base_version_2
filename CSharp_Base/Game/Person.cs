using System;

namespace Game
{
    public class Person
    {
        int hp;
        public int HealthPoints
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                    Alive = false;
                }
                else
                    hp = value;
            }
        }
        public int Level { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool Alive { get; set; } = true;

        public Person(string name)
        {
            Name = name;
            HealthPoints = 100;
            Level = 1;
            Damage = 50;
        }

        public void LevelUp()
        {
            Level++;
        }

        public void Hit(Person target)
        {
            if (Alive)
            {
                Random random = new Random();
                target.HealthPoints -= random.Next(Damage - 10, Damage + 11);
                if (target.HealthPoints == 0)
                    LevelUp();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hi, I'm {Name}, my hp: {HealthPoints}, dmg: {Damage}, lvl: {Level}");
        }
    }
}
