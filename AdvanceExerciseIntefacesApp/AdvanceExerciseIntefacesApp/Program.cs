namespace AdvanceExerciseIntefacesApp
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width*Height;
        }
    }   

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAreas();
            Console.ReadKey();
        }

        static void PrintAreas()
        {
            IShape[] shapes = {new Circle(5),new Rectangle(4,6)};
            foreach (IShape shape in shapes)            
                Console.WriteLine($"Area: {shape.GetArea()}");            
        }
    }
}
