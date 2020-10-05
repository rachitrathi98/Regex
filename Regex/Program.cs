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
            string name_regex = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(name_regex);
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
