using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class User
    {
        public string firstname;
        public User()
        {
            this.firstname = "firstname";
        }
        public string FirstName { get; set; }
        public void verifyfirstName()
        { 
        Regex regex = new Regex("^[A-Z][a-z]{2,}$");
        Console.Write("Enter the First Name");
            string firstname = Console.ReadLine();
        Match match = regex.Match(firstname);
            if (regex.IsMatch(firstname))
            {
                FirstName = firstname;
            }
            else
            {
                Console.WriteLine("Invalid Name");
                verifyfirstName();
            }              
        }
    }
}
