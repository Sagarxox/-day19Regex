using System;

namespace UC_6_PasswordRule2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            bool num = pat.Validate_Password(password);
            Console.WriteLine(num);
            if (num)
            {
                Console.WriteLine("correct match");
            }
            else
            {
                Console.WriteLine("Wrong match");
            }
        }
    }
}