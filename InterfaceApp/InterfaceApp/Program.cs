namespace InterfaceApp
{
    // Polymorphism through Interfaces Example   

    //public interface IAnimal
    //{
    //    void MakeSound();
    //    void Eat(string food);

    //}

    //public class Dog : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine("Dog eats " + food);
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Bark");
    //    }
    //}

    //public class Cat : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine("Cat eats " + food);
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Meoww");
    //    }
    //}

    // Polymorphism through Inheritance Example

    //public class Animal
    //{
    //    public virtual void MakeSound()
    //    {
    //        Console.WriteLine("Some generic animal sound");
    //    }
    //}

    //public class Dog : Animal 
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Bark");
    //    }
    //}
    //public class Cat : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Meow");
    //    }
    //}

    // More example implementing interfaces

    //public interface IPaymentProcessor
    //{
    //    void ProcessPayment(decimal amount);
    //}

    //public class CreditCardProcessor : IPaymentProcessor
    //{
    //    public void ProcessPayment(decimal amount)
    //    {
    //        Console.WriteLine($"Processing credit card payment of the {amount}");
    //        //Implement credit card payment logic.
    //    }
    //}

    //public class PaypalProcessor : IPaymentProcessor
    //{
    //    public void ProcessPayment(decimal amount)
    //    {
    //        Console.WriteLine($"Processing paypal payment of the {amount}");
    //        //Implement paypal card payment logic.
    //    }
    //}

    //public class PaymentService
    //{
    //    private readonly IPaymentProcessor _processor;

    //    public PaymentService(IPaymentProcessor processor) 
    //    {
    //        _processor = processor;
    //    }

    //    public void ProcessOrderPayment(decimal amount)
    //    {
    //        _processor.ProcessPayment(amount);
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            // The @ sign in C# is used to denote a verbatim string literal
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            string message = "This is a log entry";

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.AppendAllText(filePath, message + "\n");
            Console.ReadKey();
        }
    }
}
