using System;

namespace Game.Weapons
{
    public class Sword : IWeapon
    {
        public int Damage { get; set; }

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Разоружить противника!");
            enemy.Weapon = null;
        }
    }
}
