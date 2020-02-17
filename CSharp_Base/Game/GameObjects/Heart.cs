using System;
using System.Collections.Generic;
using System.Text;
using Game.GameObjects;

namespace Game
{
    public class Heart : GameObject
    {
        public bool Used { get; set; } = false;
        public override void Interaction(GameObject obj)
        {
            base.Interaction(obj);
            if (obj is Person person)
            {
                person.HealthPoints += 30;
                Used = true;
            }
        }
    }
}
