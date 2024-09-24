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

            //Employee joe = new Employee("Joe", 36);
            //joe.DisplayPersonInfo();            

            //Employee joe = new Employee("Joe", 36, "Sales Rep", 12345);
            //joe.DisplayEmployeeInfo();

            Manager mike = new Manager("Mike", 50, 123456, 10);
            //mike.DisplayManagerInfo();
            mike.BecomeOlder(5);

            mike.DisplayPersonInfo();

            //Console.WriteLine(mike.ToString());

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

        /// <summary>Makes our object older!</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age.</param>
        /// <returns>Returns the new age after aging/becoming older.</returns>                              
        public int BecomeOlder(int years)
        {
            Age = Age + years;

            return Age;
        }
    }

  
    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        // Derived class constructor
        public Employee(string name, int age, string jobTitle, int employeeID) 
            : base(name, age) // Calling the base class constructor
        {                
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (derived class) constructor called");           
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Name: {Name}, Age: {Age}, Job Title: {JobTitle}, Employe ID: {EmployeeID}");
        }

    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, int employeeID, int teamSize) 
            : base(name, age, "Manager", employeeID)
        {
            TeamSize = teamSize;
            Console.WriteLine("Manager (2nd derived class) constructor called");
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo(); // Call method from base class
            Console.WriteLine($"Name: {Name}, Age: {Age}, Job Title: Manager, " +
                            $"Employe ID: {EmployeeID}, Team Size: {TeamSize}");
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



