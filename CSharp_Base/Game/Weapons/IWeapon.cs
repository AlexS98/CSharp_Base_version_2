using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface IWeapon
    {
        public bool Taken { get; set; }
        public int Damage { get; set; }
        public void SpecialAttack(GamePerson enemy);
    }
}
