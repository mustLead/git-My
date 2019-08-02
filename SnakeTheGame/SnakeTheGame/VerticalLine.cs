using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class VerticalLine
    {
        List<point> pList;

        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            pList = new List<point>();
            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, symb);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }
    }
}
