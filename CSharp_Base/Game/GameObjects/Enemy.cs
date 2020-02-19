using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameObjects
{
    public class Enemy : Person
    {
        public Enemy(string name, int id) : base(name, id)
        {
        }

        public override Position Move(string direction)
        {
            // AI Move
            return new Position(0, 0);
        }
    }
}
