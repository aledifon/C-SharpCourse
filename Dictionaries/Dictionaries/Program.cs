using System.Net.NetworkInformation;
using System.Numerics;
using System;

namespace Dictionaries
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }
    }

    internal class Program
    {
        //public void PrintStudents()
        //static void PrintStudents() 
        //{            
        //    // Students objects instances
        //    Student stud1 = new Student(1, "John", 85);
        //    Student stud2 = new Student(2, "Alice", 90);
        //    Student stud3 = new Student(3, "Bob", 78);

        //    Dictionary<string, Student> students = new Dictionary<string, Student>
        //    {
        //        [stud1.Name] = stud1,
        //        [stud2.Name] = stud2,
        //        [stud3.Name] = stud3
        //    };

        //    // TODO
        //    foreach (var item in students)
        //        Console.WriteLine($"Name: {item.Key}, Id: {item.Value.Id}, Grade: {item.Value.Grade}");                        
        //}
        //public void PrintStudents(Dictionary<string, Student> students)
        static void PrintStudents(Dictionary<string, Student> students)
        {            
            // TODO
            foreach (var item in students)
                Console.WriteLine($"Name: {item.Key}, Id: {item.Value.Id}, Grade: {item.Value.Grade}");            
        }

        static void Main(string[] args)
        {
            ////////////////////////////
            // Code Challenge Advanced//
            ////////////////////////////

            //Program program = new Program();      // for non-static PrintStudents Method        
            //program.PrintStudents();            

            //PrintStudents();                        // for static PrintStudents Method        


            //Console.ReadKey();

            ////////////////////////////
            // Code Challenge Advanced//
            ////////////////////////////

            // Alternative Solution

            // Students objects instances
            Student stud1 = new Student(1, "John", 85);
            Student stud2 = new Student(2, "Alice", 90);
            Student stud3 = new Student(3, "Bob", 78);

            var students = new Dictionary<string, Student>
            {
                [stud1.Name] = stud1,
                [stud2.Name] = stud2,
                [stud3.Name] = stud3
            };

            //Program program = new Program();          // for non-static PrintStudents Method        
            //program.PrintStudents(students);

            PrintStudents(students);                  // for static PrintStudents Method


            Console.ReadKey();


            ///////////////////////////////////////////////////
            //// Dictionaries alternative initialisation ways//
            ///////////////////////////////////////////////////

            //var codes = new Dictionary<string, string>
            //{
            ////  [Key]  = Value
            //    ["NY"] = "New York",
            //    ["CA"] = "California",
            //    ["TX"] = "Texas",

            //};            

            //if (codes.TryGetValue(("NY"), out string state))            
            //    Console.WriteLine(state);

            //foreach(var item in codes)            
            //    Console.WriteLine($"The state code is {item.Key} and the state name is {item.Value}");

            //Console.ReadKey();

            //////////////////////
            //// Code Challenge //
            //////////////////////

            ////Using a Complex Object as the Value of a Dictionary
            ////#########################################
            ////Please, avoid changing the given source code for the exercise!So only add code, don't modify unless it is instructed to do so!
            ////#########################################
            ////Create a simple C# program that declares a dictionary with string keys and values of type List<int>, initializes it with one key-value pair, and prints the values of the list for the given key to the console.

            ////Alert!
            ////The result of execution for the default string should be:
            ////"1 2 3"

            //Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            //dict.Add("Primer", new List<int> {1, 2, 3});

            //foreach (var item in dict["Primer"])            
            //    Console.Write($"{item} ");

            //Console.ReadKey();


            //////////////////////////////////////
            //// Dictionary<int, Employee> VERSION//
            //////////////////////////////////////
            //Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            //employees.Add(1,new Employee("John Does", 35, 100000));
            //employees.Add(2, new Employee("John Doesnt", 25, 200000));
            //employees.Add(3, new Employee("John Wasnt", 45, 80000));
            //employees.Add(4, new Employee("John Will", 15, 50000));

            //foreach(var item in employees)
            //{
            //    Console.WriteLine($"ID: {item.Key} named {item.Value.Name} " +
            //                    $"of {item.Value.Age} years old " +
            //                    $"earns {item.Value.Salary} $");
            //}

            //Console.ReadKey();


            ////////////////////////////////////
            // Dictionary<int, string> VERSION//
            ////////////////////////////////////

            //// key - value
            //// Declaring and initializing a Dictionary
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            //// Adding Items to a Dictionary
            //employees.Add(101, "John Doe");
            //employees.Add(102, "Bob Smith");
            //employees.Add(103, "Rob Smith");
            ////employees.Add(104, "Flob Smith");
            //employees.Add(105, "Dob Smith");

            //// access items in a dictionary
            //string name = employees[101];
            ////Console.WriteLine(name);

            //// Update data in a dictionary
            //employees[102] = "Jane Smith";

            //// remove an item from a dictionary
            //employees.Remove(101);

            //// Add an item into the dictionary (avoiding duplicates)
            //if (!employees.ContainsKey(104))
            //{
            //    employees.Add(104, "Mike Jike");
            //}

            //// Adding method (Searching the next available key-position)
            //int counter = 101;
            //while (employees.ContainsKey(counter))            
            //    counter++;
            //employees.Add(counter, "Jesus Christ");

            //// TryAdd Method (Similar to Tryparse metod)
            //bool added = employees.TryAdd(102, "Michael Brims");
            //if (!added)
            //    Console.WriteLine("Employee with the id of 102 already exist");


            //// Non-Sorted dictionary
            //Console.WriteLine("NON-SORTED DICTIONARY\n");

            //// Iterating over a dictionary
            //foreach (KeyValuePair<int, string> employee in employees)
            //{
            //    Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            //}

            //Console.WriteLine("\n");

            //// Sorted dictionary
            //Console.WriteLine("SORTED DICTIONARY\n");

            //var dictSortedByKey = employees.OrderBy(kvp => kvp.Key);

            //foreach (var kvp in dictSortedByKey)
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            //employees = dictSortedByKey.ToDictionary();

            //Console.ReadKey();
        }
    }
}
