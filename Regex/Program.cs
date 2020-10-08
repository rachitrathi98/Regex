using System;
using System.Text.RegularExpressions;

namespace UserRegex

{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Console.WriteLine("Enter your first name with first letter in capitals ");
            string fname = Console.ReadLine();
            string name_pattern = "^[A-Z]{1}[a-z]{2,}";//Name starts with Cap and has 3 minimum characters
            Regex regex = new Regex(name_pattern);
            if (regex.IsMatch(fname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
    
    }
}
