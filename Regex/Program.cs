using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegex

{
    public class Program
    
    {   
        public static string fname, lname, email, phoneNo, password;
        public static string name_pattern, email_pattern, phone_pattern, password_pattern;
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to User Registration Program");
         
            }
            public Boolean FirstNameRegex() 
            {
                while (true)
                {
                    fname = "Rachitrathi";
                    name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                    Regex regex = new Regex(name_pattern);
                    if (regex.IsMatch(fname))
                    {
                        Console.WriteLine("Valid First Name");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid First Name");
                        return false;
                    }
                }
            }
            public Boolean LastNameRegex()
            {
                while (true)
                {
                    lname = "Rathirachit";
                    name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                    Regex regex = new Regex(name_pattern);
                    if (regex.IsMatch(lname))
                    {
                        Console.WriteLine("Valid Last Name");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Last Name");
                        return false;
                    }
                }
            }

            public Boolean Email_Id()
            {
                while (true)
                {
                string[] samples = {"abc@yahoo.com","abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
            "abc-100@abc.net" };
                    email_pattern = @"^[A-Za-z]+[.+-]?[a-z]*[@][A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
                    Regex regex = new Regex(email_pattern);
                foreach (var sample in samples)
                {
                    if (regex.IsMatch(sample))
                    {
                        Console.WriteLine("Valid Email: " + sample);
                    }
                    else
                    {
                        Console.WriteLine("Invalid email:" + sample);
                    }
                }
            }
            }
            
                while (true)
                {
                    phoneNo = "91 9004025062";
                    phone_pattern = @"^[0-9]{2}[ ][0-9]{10}$";
                    Regex regex = new Regex(phone_pattern);
                    if (regex.IsMatch(phoneNo))
                    {
                        Console.WriteLine("Valid Phone Number: " + phoneNo);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Phone Number");
                        return false;
                    }
                }
            

            
                while (true)
                {
                password = "Rachit123*";
                    password_pattern = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                    Regex regex = new Regex(password_pattern);
                    if (regex.IsMatch(password))
                    {
                        Console.WriteLine("Password set Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Enter password again");
                    }
               }     
    }
}
