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
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////
            // Dictionary<int, Employee> VERSION//
            ////////////////////////////////////
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1,new Employee("John Does", 35, 100000));
            employees.Add(2, new Employee("John Doesnt", 25, 200000));
            employees.Add(3, new Employee("John Wasnt", 45, 80000));
            employees.Add(4, new Employee("John Will", 15, 50000));
            
            foreach(var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named {item.Value.Name} " +
                                $"of {item.Value.Age} years old " +
                                $"earns {item.Value.Salary} $");
            }

            Console.ReadKey();

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
