using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface IWeapon
    {
        public int Damage { get; set; }
        public void SpecialAttack(Person enemy);
    }
}
