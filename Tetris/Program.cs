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
                new Dot(1, 3), 
            });

            Console.WriteLine(figure.figureArray[0, 0]);
            
            
            int[,] test =
            {
                {1, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
            };
            
            ConsoleKeyInfo keyinfo;
            do
            {
                
                keyinfo = Console.ReadKey(true);
                Console.Clear();
                figure.figureArray = RotateMatrix(figure.figureArray, 4);
                PrintFigure(figure.figureArray);
            }
            while (keyinfo.Key != ConsoleKey.X);
        }
            
        private static void PrintFigure(Figure figure)
        {
            foreach (var figureDot in figure.Dots)
            {
                
            }    
        }
        
        private static void PrintFigure(int[,] figure)
        {            
            var s = Encoding.GetEncoding("iso-8859-1");
            for (var i = 0; i < figure.GetLength(0); i++)
            {
                for (var j = 0; j < figure.GetLength(1); j++)
                {
                    if (figure[i, j] == 1)
                    {
                        Console.Write('█');
                        //█
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine();
            }
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