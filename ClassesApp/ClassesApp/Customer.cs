using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;


        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Read-Only Property
        public int Id { get => _id; }


        // Backing field for write-only property
        private string _password;

        // Write-Only property
        public string Password { set{_password = value;} } 

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        

        // Default Constructor
        public Customer()
        {            
            _id = nextId++;                 //Increment The next Customer Id, and assign the current one
            Name = "Default Name";
            Address = "No address";
            ContactNumber = "No contactNumber";            
        }

        // Default/optional parameter addresss and contactNumber
        public Customer(string name, string address = "NA" , string contactNumber = "NA")
        {            
            _id = nextId++;                 //Increment The next Customer Id, and assign the current one
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default parameter contactNumber
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and Id is {Id}");
        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I am doing some customer stuff");
        }

    }
}
