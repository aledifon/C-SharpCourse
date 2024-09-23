namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            //myDog.MakeSound();
            ////myDog.Eat();

            //Cat mycat = new Cat();
            //mycat.MakeSound();

            Employee joe = new Employee("Joe", 36);
            joe.DisplayPersonInfo();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Base class constructor
        public Person(string name, int age)
        {            
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        
    }


    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age)
        {
            Console.WriteLine("Employee (derived class) constructor called");
        }
    }

    // Base Class (Parent Class or Superclass): The class whose members are inherited
    class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Eating...");
        }

        // Making this method virtual allows us to override it
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    } 


    // Single inheritance example
    // Derived Class (Child Class or Subclass):
    // The class that inherits the members of the base class
    class Dog: Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }

    // Hierarquical inheritance
    class Cat : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Cat is meowing");
        }
    }

    // Multilevel inheritance example
    // A breed of dog
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }

    // Also there is a 4th type of inheritance (Multiple inheritance)
    // only possible through interfaces

}



