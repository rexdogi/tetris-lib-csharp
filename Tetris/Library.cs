﻿using System;

namespace Tetris
{
    public class Library: ITetrisInteface
    {
        private const int WALL_WIDTH = 2;
        private const int ROWS = 20 + WALL_WIDTH;
        private const int COLUMNS = 10 + WALL_WIDTH;
        private int figureRow = 0;
        private int figureCol = 0;


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
            }
            return gameArea;
        }

        public int[,] SetFigurePosition(Figure figure, int row, int col, int[,] arr)
        {
            var fRow = 0;
            var fCol = 0;;
            if(col == 0)
            {
                bool canShiftLeft = figure.CanShiftHorizontally(Direction.LEFT);
                if (canShiftLeft)
                {
                    figure.Shift(Direction.LEFT);
                }
            }
            else if(col == GameConstants.COLS - 4)
            {
                bool canShiftRight = figure.CanShiftHorizontally(Direction.RIGHT);
                if (canShiftRight)
                {
                    figure.Shift(Direction.RIGHT);
                }
            }

            if (row == GameConstants.ROWS - 4)
            {
                bool canShiftDown = figure.CanShiftVertically(Direction.DOWN);
                if (canShiftDown)
                {
                    figure.Shift(Direction.DOWN);
                }

            }         

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

        public bool MoveFigure(Direction direction, int row, int col)
        {
            switch (direction)
            {
                    case Direction.LEFT:
                        break;
                    case Direction.RIGHT:
                       break;
                    case Direction.DOWN:
                        break;
            }
            return false;
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
//■