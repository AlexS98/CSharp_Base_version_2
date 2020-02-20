using System;

namespace Game.Weapons
{
    public class Knife : CommonWeapon
    {
        public Knife()
        {
            Damage = 15;
            Name = nameof(Knife);
        }

        public override void SpecialAttack(GamePerson enemy)
        {
            Console.WriteLine("Venom!");
            enemy.HealthPoints -= 15;
        }
    }
}
