﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class snake : figure
    {
        public snake(point tail, int length, Direction direction)
        {
            pList = new List<point>();
            for(int i=0; i< length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
