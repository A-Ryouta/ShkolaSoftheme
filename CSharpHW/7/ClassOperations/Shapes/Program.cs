using System;

namespace Shapes
{
    class Program
    {
        static void Main()
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
}
