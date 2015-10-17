using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine:Figure
    {
        public VerticalLine(int topY, int downY, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = topY; y <= downY; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }           
        }

    }
}
