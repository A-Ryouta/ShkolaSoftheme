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
            ShapeDescriptor nothing = new ShapeDescriptor();
            ShapeDescriptor single = new ShapeDescriptor(new Point(1, 1));
            ShapeDescriptor line = new ShapeDescriptor(new Point(1, 2), new Point(3, 3));
            ShapeDescriptor triple = new ShapeDescriptor(new Point(1, 1), new Point(5, 2), new Point());
            ShapeDescriptor fourth = new ShapeDescriptor(new Point(0, 0), new Point(0, 4), new Point(4, 4), new Point(4, 0));

            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}\n", nothing.ShapeType, single.ShapeType,
                line.ShapeType, triple.ShapeType, fourth.ShapeType);
            Console.ReadLine();
        }
    }

    class ShapeDescriptor
    {
        public string ShapeType { get; }
        private Point point1, point2, point3, point4;

        public ShapeDescriptor()
        {
            ShapeType = "Null";
        }
        public ShapeDescriptor(Point p)
        {
            point1 = p;
            ShapeType = "Point";
        }
        public ShapeDescriptor(Point p1, Point p2)
        {
            point1 = p1;
            point2 = p2;
            ShapeType = "Line";
        }
        public ShapeDescriptor(Point p1, Point p2, Point p3)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            ShapeType = "Triangle";
        }
        public ShapeDescriptor(Point p1, Point p2, Point p3, Point p4)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = p4;
            ShapeType = "Quad";
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
