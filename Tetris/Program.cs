using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tetris
{
    internal static class Program
    {
        public static void Main(string[] args)
        {

            const int WALL_WIDTH = 1;
            var figure = new Figure(new Dot[]
            {
                new Dot(0, 0),
                new Dot(0, 1),
                new Dot(0, 2),
                new Dot(0, 3), 
            }, 4);         

            var gameBoard = new Library();
            var row = 0;
            var col = 0;
            
            ConsoleKeyInfo keyinfo;
            do
            {
                
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.Key)
                {
                        case ConsoleKey.UpArrow:
                            figure.Rotate();
                            break;
                        case ConsoleKey.DownArrow:
                        if (row + 1<= GameConstants.ROWS - 4)
                        {
                            row++;
                        }
                            break;
                        case ConsoleKey.RightArrow:
                        if (col + 1 < 7)
                        {
                            col++;
                        }
                        break;
                        case ConsoleKey.LeftArrow:
                        if(col - 1 >= 0)
                        {
                            col--;
                        }
                            break;
                            default:
                                break;
                }
                Console.SetCursorPosition(0, 0);         
                var ar = gameBoard.GetGameArray();
                var lul = gameBoard.SetFigurePosition(figure, row, col, ar);
                GUI.PrintGame(lul);
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.Read();
        }
    }
}