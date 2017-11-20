namespace Tetris
{
    public class Figure
    {
        public Dot[] Dots { get; }
        public int[,] figureArray {get; set; }
        
        public Figure(Dot[] dots)
        {
            figureArray = new int[4, 4];
            foreach (var dot in dots)
            {
                figureArray[dot.x, dot.y] = 1;
            }
        }

    }
}