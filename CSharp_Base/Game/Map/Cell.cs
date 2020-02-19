using System;
using System.Collections.Generic;
using System.Text;
using Game.GameObjects;

namespace Game
{
    public class Cell
    {
        public GameObject GameObject { get; set; }

        public Cell()
        {
        }

        public Cell(GameObject gameObject)
        {
            GameObject = gameObject;
        }

        public bool IsEmpty()
        {
            return GameObject == null;
        }
    }
}
