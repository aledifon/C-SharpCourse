using System.Security.Cryptography.X509Certificates;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseclase = new BaseClass();
            baseclase.ShowFields();

            DerivedClass derivedclase = new DerivedClass();
            derivedclase.AccessFields();
            derivedclase.ShowFields();

            Console.ReadKey();
        }
    }

    class BaseClass
    {
        // access modifiers
        public int publicField;
        protected int protectedField;
        private int privateField =5;        

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " +
                $"Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass: BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            //privateField = 3;
        }        
    }
}
