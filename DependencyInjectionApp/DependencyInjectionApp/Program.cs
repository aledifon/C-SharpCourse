namespace DependencyInjectionApp
{    
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    //public class Tools
    //{
    //    public Hammer hammer;
    //    public Saw saw;
    //}

    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }        

        // Setter Dependency Injection (DI)       

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House built");
        }
    }    

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();   // Create the dependencies outside     
            Saw saw = new Saw();    
            Builder builder = new Builder();
            builder.Hammer = hammer;        // Inject dependencies via Setters
            builder.Saw = saw;              // Inject dependencies via Setters

            builder.BuildHouse();   

            Console.ReadKey();
        }
    }
}
