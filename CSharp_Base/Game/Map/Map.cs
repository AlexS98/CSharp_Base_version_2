using System;

namespace Game
{
    public class Map
    {
        public int WorldHeight { get; }
        public int WorldWidth { get; }
        public Cell[,] Cells { get; }

        public Map(int height, int width)
        {
            Cells = new Cell[height, width];
            WorldHeight = height;
            WorldWidth = width;
        }

        public void GenerateMap()
        {
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    Cells[i, k] = new Cell();
                }
            }
        }

        public bool InitPerson(Person person, int position1, int position2)
        {
            return InitPerson(person, new Position(position1, position2));
        }
        public bool InitPerson(Person person, Position position)
        {
            if (position.Pos1 >= 0 && position.Pos2 >= 0 &&
                position.Pos1 < WorldHeight && position.Pos2 < WorldWidth)
            {
                Cell wantedCell = Cells[position.Pos1, position.Pos2];
                if (wantedCell.PersonOnCell == null && wantedCell.HeartOnCell == null)
                {
                    wantedCell.PersonOnCell = person;
                    person.World = this;
                    return true;
                }
            }
            return false;
        }

        public bool InitPerson(Heart heart, Position position)
        {
            if (position.Pos1 >= 0 && position.Pos2 >= 0 &&
                position.Pos1 < WorldHeight && position.Pos2 < WorldWidth)
            {
                Cell wantedCell = Cells[position.Pos1, position.Pos2];
                if (wantedCell.PersonOnCell == null && wantedCell.HeartOnCell == null)
                {
                    wantedCell.HeartOnCell = heart;
                    return true;
                }
            }
            return false;
        }

        public Position GetPersonPosition(Person person)
        {
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    if (Cells[i, k].PersonOnCell == person)
                        return new Position(i, k);
                }
            }
            return null;
        }

        public bool IsEmpty(Position position)
        {
            return Cells[position.Pos1, position.Pos2].IsEmpty();
        }

        public Cell GetCell(Position position)
        {
            return Cells[position.Pos1, position.Pos2];
        }

        public void Show()
        {
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    Extensions.ToConsoleWrite("|", ConsoleColor.Green);
                    if (Cells[i, k].PersonOnCell != null && Cells[i, k].PersonOnCell.Id == 1)
                        Extensions.ToConsoleWrite("☺", ConsoleColor.Cyan);
                    else if (Cells[i, k].PersonOnCell != null)
                        Extensions.ToConsoleWrite("☻", ConsoleColor.Red);
                    else if (Cells[i, k].HeartOnCell != null)
                        Extensions.ToConsoleWrite("♥", ConsoleColor.Red);
                    else
                        Extensions.ToConsoleWrite(" ");
                }
                Extensions.ToConsole("|", ConsoleColor.Green);
            }
        }

        public void Refresh()
        {
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    if (Cells[i, k].PersonOnCell != null && !Cells[i, k].PersonOnCell.Alive)
                        Cells[i, k].PersonOnCell = null;
                    if (Cells[i, k].HeartOnCell != null && Cells[i, k].HeartOnCell.Used)
                        Cells[i, k].HeartOnCell = null;
                }
            }
        }
    }
}
