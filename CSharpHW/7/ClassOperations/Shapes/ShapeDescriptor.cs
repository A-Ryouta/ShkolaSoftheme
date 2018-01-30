namespace Shapes
{
    internal class ShapeDescriptor
    {
        public string ShapeType { get; }
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }
        public Point Point4 { get; }

        public ShapeDescriptor()
        {
            ShapeType = "Undefined";
        }

        public ShapeDescriptor(Point p)
        {
            Point1 = p;
            ShapeType = "Point";
        }

        public ShapeDescriptor(Point p1, Point p2)
        {
            Point1 = p1;
            Point2 = p2;
            ShapeType = "Line";
        }

        public ShapeDescriptor(Point p1, Point p2, Point p3)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;
            ShapeType = "Triangle";
        }

        public ShapeDescriptor(Point p1, Point p2, Point p3, Point p4)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;
            Point4 = p4;
            ShapeType = "Quad";
        }
    }
}
