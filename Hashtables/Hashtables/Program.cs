using System.Collections;
using System.Reflection.Metadata;

namespace Hashtables
{
    internal class Program
    {
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            // Hashtable creation
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            // Add Key - Value pairs entries to our hashtable
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);            

            // Retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retrive all values from a Hashtable
            //foreach (DictionaryEntry entry in studentsTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine("Student ID:{0}", temp.Id);
            //    Console.WriteLine("Student Name:{0}", temp.Name);
            //    Console.WriteLine("Student GPA:{0}", temp.GPA);
            //}

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }    


            //Console.WriteLine("Sudent ID:{0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.ReadKey();

        }
    }

    class Student
    {
        // property called Id
        public int Id { get; set; }
        // property called Name
        public string Name { get; set; }
        // property called GPA
        public float GPA { get; set; }

        // simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
