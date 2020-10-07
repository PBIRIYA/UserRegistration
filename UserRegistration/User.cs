using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class User
    {
        public string firstname;
        public string lastname;
        public User()
        {
            this.firstname = "firstname";
            this.lastname = "lastname";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void verifyfirstName()
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            Console.Write("Enter the First Name-");
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
            public void verifylastName()
            {
                Regex regex = new Regex("^[A-Z][a-z]{2,}$");
                Console.Write("Enter the Last Name-");
                string lastname = Console.ReadLine();
                Match match = regex.Match(lastname);
                if (regex.IsMatch(lastname))
                {
                    LastName = lastname;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                    verifylastName();
                }
            }
        }
    }


