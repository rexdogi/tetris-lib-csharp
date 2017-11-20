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
           
            var figure = new Figure(new Dot[]
            {
                new Dot(0, 0),
                new Dot(0, 1),
                new Dot(0, 2),
                new Dot(1, 2), 
            }, 3);         

            var gameBox = new GameBox();
            var row = 0;
            var col = 0;
            
            ConsoleKeyInfo keyinfo;
            do
            {
                
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.Key)
                {
                        case ConsoleKey.UpArrow:
                            figure.figureArray = RotateMatrix(figure.figureArray, figure.size);
                            break;
                        case ConsoleKey.DownArrow:
                            row++;
                            break;
                        case ConsoleKey.RightArrow:
                            col++;
                            break;
                        case ConsoleKey.LeftArrow:
                            col--;
                            break;
                            default:
                                break;
                }
                           
                Console.Clear();
                var ar = gameBox.GetGameArray();
                var lul = gameBox.SetFigurePosition(figure, row, col, ar);
                Helpers.PrintGame(lul);
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.Read();
        }
        
        private static int[,] RotateMatrix(int[,] matrix, int n) {
            var ret = new int[n, n];

            for (var i = 0; i < n; ++i) {
                for (var j = 0; j < n; ++j) {
                    ret[i, j] = matrix[n - j - 1, i];
                }
            }

            return ret;
        }
    }
}