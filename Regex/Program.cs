using System;
using System.Text.RegularExpressions;

namespace UserRegex

{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            string fname, lname;
            string name_pattern;
            while (true)
            {
                Console.WriteLine("Enter your first name with first letter in capitals ");
                fname = Console.ReadLine();
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";////First Name starts with Cap and has 3 minimum characters
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
                name_pattern = @"^[A-Z]{1}[a-z]{2,}"; //Last Name starts with Cap and has 3 minimum characters
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
        }
    
    }
}
