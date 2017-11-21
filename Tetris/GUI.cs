using System;

namespace Tetris
{
    public class GUI
    {
        public static void PrintGame(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    switch ((BlockType) array[i, j])
                    {
                        case BlockType.EmptySpace:
                            Console.Write(" ");
                            break;
                        case BlockType.FigureBlock:
                            Console.Write("■");
                            break;
                        case BlockType.WallBlock:
                            Console.Write("█");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}