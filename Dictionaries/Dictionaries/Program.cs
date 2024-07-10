namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            // Declaring and initializing a Dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding Items to a Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            //employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");

            // access items in a dictionary
            string name = employees[101];
            //Console.WriteLine(name);

            // Update data in a dictionary
            employees[102] = "Jane Smith";

            // remove an item from a dictionary
            employees.Remove(101);

            // Add an item into the dictionary (avoiding duplicates)
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            // Adding method (Searching the next available key-position)
            int counter = 101;
            while (employees.ContainsKey(counter))            
                counter++;
            employees.Add(counter, "Jesus Christ");

            // TryAdd Method (Similar to Tryparse metod)
            bool added = employees.TryAdd(102, "Michael Brims");
            if (!added)
                Console.WriteLine("Employee with the id of 102 already exist");


            // Non-Sorted dictionary
            Console.WriteLine("NON-SORTED DICTIONARY\n");

            // Iterating over a dictionary
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            Console.WriteLine("\n");

            // Sorted dictionary
            Console.WriteLine("SORTED DICTIONARY\n");

            var dictSortedByKey = employees.OrderBy(kvp => kvp.Key);

            foreach (var kvp in dictSortedByKey)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            employees = dictSortedByKey.ToDictionary();

            Console.ReadKey();
        }
    }
}
