using System;

namespace Game.GameObjects
{
    public class Enemy : Person
    {
        public Enemy(string name, int id) : base(name, id)
        {
        }

        public override Position Move(string direction)
        {
            Position currentPos = World.GetPersonPosition(this);

            if (currentPos == null)
            {
                Console.WriteLine("Can't find {0}", Name);
                return null;
            }

            Cell currentCell = World.GetCell(currentPos);

            Random random = new Random();

            direction = random.Next(0, 4).ToString();

            switch (direction)
            {
                case "0":
                    if (currentPos.Pos1 >= 1)
                        currentPos.Pos1--;
                    break;
                case "1":
                    if (currentPos.Pos1 <= World.WorldHeight - 2)
                        currentPos.Pos1++;
                    break;
                case "2":
                    if (currentPos.Pos2 <= World.WorldWidth - 2)
                        currentPos.Pos2++;
                    break;
                case "3":
                    if (currentPos.Pos2 >= 1)
                        currentPos.Pos2--;
                    break;
                default:
                    break;
            }
            Cell wantedCell = World.GetCell(currentPos);

            if (wantedCell.IsEmpty())
            {
                currentCell.GameObject = null;
                wantedCell.GameObject = this;
            }
            else
            {
                wantedCell.GameObject.Interaction(this);
                World.Refresh();
            }
            return currentPos;
        }
    }
}
