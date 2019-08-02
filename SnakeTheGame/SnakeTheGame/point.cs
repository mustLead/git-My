using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class point
    {
        public int x;
        public int y;
        public char symb;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
