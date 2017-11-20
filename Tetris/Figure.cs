namespace Tetris
{
    public class Figure
    {
        public Dot[] Dots { get; }
        public int[,] figureArray {get; set; }
        public int size { get; }
        
        public Figure(Dot[] dots, int size)
        {
            this.size = size;
            figureArray = new int[size, size];
            foreach (var dot in dots)
            {
                figureArray[dot.x, dot.y] = 1;
            }
        }

    }
}