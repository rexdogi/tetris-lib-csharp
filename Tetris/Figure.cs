using System.Runtime.CompilerServices;

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
        
        public void Rotate()
        {
            var n = this.size;
            var ret = new int[n, n];
            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    ret[i, j] = figureArray[n - j - 1, i];
                }
            }
            this.figureArray = ret;
        }

        public void Shift(Direction direction)
        {
            var ret = new int[size, size];

            switch (direction)
            {
                    case Direction.LEFT:
                        
                        break;
            }
            
            for (var i = 0; i < figureArray.Length; i++)
            {
                
            }
        }

        public bool CanShiftHorizontally(int[,] arr, Direction direction)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                }
            }
            return true;
        }
       

    }
}