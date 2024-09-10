namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // Base Class (Parent Class or Superclass): The class whose members are inherited
    class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }


}



