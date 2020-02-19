using System;
using Game.GameObjects;

namespace Game.Weapons
{
    public class Sword : GameObject, IWeapon
    {
        public int Damage { get; set; }

        public void SpecialAttack(Person enemy)
        {
            Console.WriteLine("Разоружить противника!");
            enemy.Weapon = null;
        }
    }
}
