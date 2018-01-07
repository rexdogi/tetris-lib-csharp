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
                    
                    for (int i = 0; i < figureArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < figureArray.GetLength(1) - 1; j++)
                        {
                            ret[i, j] = figureArray[i, j + 1];
                        }
                    }   
                    break;

                    case Direction.RIGHT:
                    for (int i = 0; i < figureArray.GetLength(0); i++)
                    {
                        for (int j = 1; j < figureArray.GetLength(1); j++)
                        {
                            ret[i, j] = figureArray[i, j - 1];
                        }
                    }
                    break;

                    case Direction.DOWN:
                    for (int i = 1; i < figureArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < figureArray.GetLength(1); j++)
                        {
                            ret[i, j] = figureArray[i - 1, j];
                        }
                    }
                    break;

            }

            this.figureArray = ret;
        }

        public bool CanShiftHorizontally(Direction direction)
        {
            bool canShift = true;
            for (int i = 0; i < figureArray.GetLength(0); i++)
            {
                switch (direction)
                {
                    case Direction.LEFT:
                        if(figureArray[i, 0] != 0)
                        {
                            canShift = false;
                        }
                        break;
                    case Direction.RIGHT:
                        if (figureArray[i, figureArray.GetLength(1) -1] != 0)
                        {
                            canShift = false;
                        }
                        break;

                }
            }
        
            return canShift;
        }

        public bool CanShiftVertically(Direction direction)
        {
            bool canShift = true;
            for (int i = 0; i < figureArray.GetLength(1); i++)
            {
                switch (direction)
                {
                    case Direction.DOWN:
                        if (figureArray[figureArray.GetLength(0) - 1, i] != 0)
                        {
                            canShift = false;
                        }
                        break;
                }
            }

            return canShift;
        }


    }
}