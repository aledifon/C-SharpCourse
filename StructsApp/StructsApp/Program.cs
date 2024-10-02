﻿namespace StructsApp
{

    public struct Point
    {
        // It's a common practice to make structs immutable
        // by declaring all fields as readonly and providing only
        // get accessors for properties
        public double X { get; set; }
        public double Y { get; set; }        

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //public double DistanceTo(Point other)
        //{
        //    double dx = other.X - X; 
        //    double dy = other.Y - Y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }        
    }
    
    public class PointClass
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {            
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2 = p1;      // p2 is a copy of p1      
            p2.Display();
            p2.X = 25;          // Changes p2, p1 remains unchanged
            p1.Display();
            p2.Display();

            Console.WriteLine("NOW COME THE CLASS OBJECTS");
            PointClass pC1 = new PointClass(1,2);
            PointClass pC2 = pC1;   // pC2 is a reference to the same object as pC1
            pC1.Display();
            pC2.Display();

            pC2.X = 3;      // Changes p1.X as well, since p1 and p2 reference the same object
            Console.WriteLine("After changing pC2.X to 3");
            pC1.Display();
            pC2.Display();

            //double distance = p1.DistanceTo(p2);
            //Console.WriteLine($"Distance between points: {distance:F2}");

            //Point p3 = p1;            
            //p1.Display();
            //p3.Display();

            bool isEqual = pC1.Equals(pC2);
            Console.WriteLine("is it equal?" + isEqual);
            Console.ReadKey();
        }
    }
}
