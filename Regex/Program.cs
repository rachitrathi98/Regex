using System;
using System.Text.RegularExpressions;

namespace UserRegex

{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname, email;
            string name_pattern, email_pattern;
            while (true)
            {
                Console.WriteLine("Enter your first name with first letter in capitals ");
                fname = Console.ReadLine();
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                if (regex.IsMatch(fname))
                {
                    Console.WriteLine("Valid First Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter your last name(only first letter in CAPS): ");
                lname = Console.ReadLine();
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                if (regex.IsMatch(lname))
                {
                    Console.WriteLine("Valid Last Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                }
            }
            Console.WriteLine("Your Entered Name is " + fname + " " + lname);
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email = Console.ReadLine();
                email_pattern = @"^[A-Za-z]+[\w.+-]*[@][A-Za-z0-9]+[.][a-z]{2,}[.]?[a-z]*$";
                Regex regex = new Regex(email_pattern);
                if (regex.IsMatch(email))
                {
                    Console.WriteLine("Valid Email-Id");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Email-Id");
                }
            }
        }
    
    }
}
