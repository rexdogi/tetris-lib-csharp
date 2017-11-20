using System;

namespace Tetris
{
    public class GameBox
    {
        private const int WALL_WIDTH = 2;
        private const int ROWS = 20 + WALL_WIDTH;
        private const int COLUMNS = 10 + WALL_WIDTH;

        public int[,] GetGameArray()
        {
            var gameArea = new int[ROWS, COLUMNS];
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (i == 0 || i == ROWS - 1 || j == 0 || j == COLUMNS - 1)
                    {
                        gameArea[i, j] = (int)BlockType.WallBlock;
                    }
                }
                Console.WriteLine();
            }
            return gameArea;
        }

        public int[,] SetFigurePosition(Figure figure, int row, int col, int[,] arr)
        {
            var fRow = 0;
            var fCol = 0;;
            for (var i = row + 1; i < figure.figureArray.GetLength(0) + row + 1; i++)
            {
                for (var j = col + 1; j < figure.figureArray.GetLength(1) + col + 1; j++)
                {
                    arr[i, j] = figure.figureArray[fRow, fCol];
                    fCol++;
                }
                fCol = 0;
                fRow++;
            }

            return arr;
        }
    }
}
//■