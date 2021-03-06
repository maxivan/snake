﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int i, Diraction diraction)
        {
            if (diraction == Diraction.RIGHT)
            {
                x = x + i;
            }

            if (diraction == Diraction.LEFT)
            {
                x = x - i;
            }

            if (diraction == Diraction.UP)
            {
                y = y - i;
            }

            if (diraction == Diraction.DOWN)
            {
                y = y + i;
            }


        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
