using System;
using System.IO;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();
        }
    }
    public class Customer
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}
