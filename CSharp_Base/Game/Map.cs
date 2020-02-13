namespace Game
{
    public class Map
    {
        public Cell[,] Cells { get; }

        public Map(int height, int width)
        {
            Cells = new Cell[height, width];
        }

        public void GenerateMap()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int k = 0; k < Cells.GetLength(1); k++)
                {

                }
            }
        }

        public void Show()
        {

        }
    }
}
