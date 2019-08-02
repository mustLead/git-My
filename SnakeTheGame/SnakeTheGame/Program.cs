using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.Draw();

            point p2 = new point(4, 5, '#');
            p2.Draw();

            point p3 = new point(8, 4, '@');
            p3.Draw();

            point p4 = new point(5, 9, '&');
            p4.Draw();

            List<char> CharList = new List<char>();
            CharList.Add('*');
            CharList.Add('#');
            CharList.Add('@');

            foreach (char c in CharList)
            {
                Console.WriteLine(c);
            }

            List<point> pointList = new List<point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            Console.ReadLine();
        }
    }
}
