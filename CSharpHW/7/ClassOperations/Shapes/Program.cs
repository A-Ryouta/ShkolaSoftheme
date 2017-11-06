using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ShapeDescriptor
    {
        public ShapeDescriptor(Point p)
        {
            p = new Point(0, 0);
        }
        public ShapeDescriptor(Point p1, Point p2)
        {
            p1 = new Point(1, 2);
            p2 = new Point(5, 1);
        }
        public ShapeDescriptor(Point p1, Point p2, Point p3)
        {
            p1 = new Point(2, 2);
            p2 = new Point(3, 5);
            p3 = new Point(6, 2);
        }
        public ShapeDescriptor(Point p1, Point p2, Point p3, Point p4)
        {
            p1 = new Point(0, 0);
            p2 = new Point(0, 4);
            p3 = new Point(4, 4);
            p3 = new Point(4, 0);
        }
    }
    class Point
    {
        int x, y;

        public Point() {}

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }


}
