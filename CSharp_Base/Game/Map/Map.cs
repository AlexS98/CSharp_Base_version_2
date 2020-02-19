using System;

using Game.GameObjects;

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

        public bool InitGameObject(GameObject gameObject, int position1, int position2)
        {
            return InitGameObject(gameObject, new Position(position1, position2));
        }
        public bool InitGameObject(GameObject gameObject, Position position)
        {
            if (position.Pos1 >= 0 && position.Pos2 >= 0 &&
                position.Pos1 < WorldHeight && position.Pos2 < WorldWidth)
            {
                Cell wantedCell = Cells[position.Pos1, position.Pos2];
                if (wantedCell.GameObject == null)
                {
                    wantedCell.GameObject = gameObject;
                    if (gameObject is Person person)
                        person.World = this;
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
                    if (Cells[i, k].GameObject == person)
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
            Console.Clear();
            Refresh();
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    Extensions.ToConsoleWrite("|", ConsoleColor.Green);
                    if (Cells[i, k].GameObject != null && Cells[i, k].GameObject is Character)
                        Extensions.ToConsoleWrite("☺", ConsoleColor.Cyan);
                    else if (Cells[i, k].GameObject != null && Cells[i, k].GameObject is Enemy)
                        Extensions.ToConsoleWrite("☻", ConsoleColor.Red);
                    else if (Cells[i, k].GameObject != null && Cells[i, k].GameObject is Heart)
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
                    if (Cells[i, k].GameObject != null)
                    {
                        if (Cells[i, k].GameObject is Heart heart && heart.Used ||
                            Cells[i, k].GameObject is Person person && !person.Alive)
                            Cells[i, k].GameObject = null;

                    }
                }
            }
        }

        public bool Winner(Person person)
        {
            for (int i = 0; i < WorldHeight; i++)
            {
                for (int k = 0; k < WorldWidth; k++)
                {
                    if (Cells[i, k].GameObject != null && Cells[i, k].GameObject != person)
                        return false;
                }
            }
            return true;
        }
    }
}
