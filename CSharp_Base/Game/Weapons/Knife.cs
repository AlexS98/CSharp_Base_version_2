using System;

namespace Game.Weapons
{
    public class Knife : IWeapon
    {
        public int Damage { get; set; }

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Отравленное оружие!");
            enemy.HealthPoints -= 15;
        }
    }
}
