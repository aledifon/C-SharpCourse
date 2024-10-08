namespace DelegatesAndEvents
{
    // 1. Declaration:
    // Is possible to declare delegates outside of the class, 
    // indeed is preferable
    public delegate void Notify(string message);

    internal class Program
    {
        //// 1. Declaration:
        //public delegate void Notify(string message);

        static void Main(string[] args)
        {
            // Delegates define a method signature,
            // and any method assigned to a delegate must match this signature.

            // 1. Declaration:

            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate = new Notify(ShowMessage);

            // 3. Invocation:
            notifyDelegate("Hello Delegates!");


            Console.ReadKey();
        }

        static void ShowMessage(string message2)
        {
            Console.WriteLine(message2);
        }
    }
}
