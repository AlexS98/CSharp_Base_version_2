using System;

namespace Game.Weapons
{
    public class Sword : CommonWeapon
    {
        public Sword()
        {
            Damage = 30;
            Name = nameof(Sword);
        }

        public override void SpecialAttack(GamePerson enemy)
        {
            Console.WriteLine("No weapon!");
            enemy.Weapon = null;
        }
    }
}
