using System;
using System.Collections.Generic;
using System.Text;
using Game.GameObjects;

namespace Game.Weapons
{
    public abstract class CommonWeapon : GameObject, IWeapon
    {
        public bool Taken { get; set; } = false;
        public override void Interaction(GameObject obj)
        {
            base.Interaction(obj);
            if (obj is GamePerson person)
            {
                person.Weapon = this;
                Taken = true;
            }

        }

        public int Damage { get; set; }

        public abstract void SpecialAttack(GamePerson enemy);
    }
}
