using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Cell
    {
        public Person PersonOnCell { get; set; }
        public Heart HeartOnCell { get; set; }

        public Cell()
        {
        }

        public Cell(Person personOnCell)
        {
            PersonOnCell = personOnCell;
        }

        public Cell(Heart heartOnCell)
        {
            HeartOnCell = heartOnCell;
        }

        public bool IsEmpty()
        {
            return PersonOnCell == null && HeartOnCell == null;
        }
    }
}
