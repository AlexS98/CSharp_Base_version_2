using System;

using Game.GameObjects;

namespace Game
{
    public abstract class Person : GameObject
    {
        int id;
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
        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Level { get; set; }
        public int Damage { get; set; }
        public bool Alive { get; set; } = true;
        public Map World { get; set; }
        public IWeapon Weapon { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            HealthPoints = 100;
            Level = 1;
            Damage = 20;
            this.id = id;
        }

        public void LevelUp()
        {
            Level++;
            HealthPoints += 50;
        }

        public void Hit(Person target)
        {
            if (Alive)
            {
                Random random = new Random();
                target.HealthPoints -= random.Next(Damage - 5, Damage + 6) + (Weapon?.Damage ?? 0);
                if (random.Next(0, 5) == 4)
                    Weapon?.SpecialAttack(target);
                if (target.HealthPoints == 0)
                    LevelUp();
            }
        }

        public void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"{Name}, my hp: {HealthPoints}, dmg: {Damage}, lvl: {Level}");
            else
                Console.WriteLine($"{Name} die");
        }

        public override void Interaction(GameObject obj)
        {
            base.Interaction(obj);
            if (obj is Person person && person != this)
            {
                Battle newBattle = new Battle(person, this);
                Person winner = newBattle.Fight();
            }
        }

        public abstract Position Move(string direction);
    }
}
