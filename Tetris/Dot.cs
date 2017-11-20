using System.Dynamic;

namespace Tetris
{
    public class Dot
    {
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int x { get; }
        public int y { get; }
        
    }
}