using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GameObjects
{
    public class Character : Person
    {
        public Character(string name, int id) : base(name, id)
        {
        }

        public override Position Move(string direction)
        {
            Position currentPos = World.GetPersonPosition(this);
            Cell currentCell = World.GetCell(currentPos);

            if (currentPos == null)
            {
                Console.WriteLine("Can't find {0}", Name);
                return null;
            }

            switch (direction)
            {
                case "w":
                    if (currentPos.Pos1 >= 1)
                        currentPos.Pos1--;
                    break;
                case "s":
                    if (currentPos.Pos1 <= World.WorldHeight - 2)
                        currentPos.Pos1++;
                    break;
                case "d":
                    if (currentPos.Pos2 <= World.WorldWidth - 2)
                        currentPos.Pos2++;
                    break;
                case "a":
                    if (currentPos.Pos2 >= 1)
                        currentPos.Pos2--;
                    break;
                default:
                    break;
            }
            Cell wantedCell = World.GetCell(currentPos);

            if (wantedCell.IsEmpty())
            {
                currentCell.PersonOnCell = null;
                wantedCell.PersonOnCell = this;
            }
            else if (wantedCell.HeartOnCell != null)
            {
                wantedCell.HeartOnCell.Interaction(this);
                World.Refresh();
            }
            else if (wantedCell.PersonOnCell != null)
            {
                wantedCell.PersonOnCell.Interaction(this);
                World.Refresh();
            }
            return currentPos;
        }
    }
}
