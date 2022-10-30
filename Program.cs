using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tWelcome To User Registration Problem");

            Console.Write("\nEnter The Last Name:");
            String lname = Console.ReadLine();

            if (UserRegistration.validate(lname))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }

}