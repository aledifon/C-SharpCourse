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
        private Hammer _hammer;
        private Saw _saw;

        //public Builder(Tools tools)
        //{
        //    _hammer = tools.hammer; // Builder is responsible for creating its dependencies
        //    _saw = tools.saw;
        //}

        // Constructor Dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer; // Builder is responsible for creating its dependencies
            _saw = saw;
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built");
        }
    }    

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();    
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();   

            Console.ReadKey();
        }
    }
}
