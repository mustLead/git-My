﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class HorizontalLine
    {
        List<point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, symb);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(point p in pList)
            {
                p.Draw();
            }
        }      
    }
}
