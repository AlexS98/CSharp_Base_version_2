using System;
using System.Collections.Generic;
using System.Text;
using Game.GameObjects;

namespace Game
{
    public class Heart : GameObject
    {
        public bool Used { get; set; } = false;
        public Heart()
        {
            Name = "Heart";
        }
        public override void Interaction(GameObject obj)
        {
            base.Interaction(obj);
            if (obj is GamePerson person)
            {
                person.HealthPoints += 30;
                Used = true;
            }
        }
    }
}
