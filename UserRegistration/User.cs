﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class User
    {
        public string firstname;
        public string lastname;
        public string email;
        public string mobilenumber;
        public string password;
        public User()
        {
            this.firstname = "firstname";
            this.lastname = "lastname";
            this.email = "email";
            this.mobilenumber = "mobilenumber";
            this.password = "password";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
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
        public void verifyemail()
        {
            Regex regex = new Regex("^[a-z1-9]{1,}(.[a-z1-9]{1,}){0,}@[a-z]{1,}[.]{1}[a-z]{1,}(.[a-z]{1,}){0,}$");
            Console.Write("Enter Email Address-");
            string email = Console.ReadLine();
            Match match = regex.Match(email);
            if (regex.IsMatch(email))
            {
                Email = email;
            }
            else
            {
                Console.WriteLine("Invalid Email Address");
                verifyemail();
            }
        }
        public void verifymobilenumber()
        {
            Regex regex = new Regex("^[6-9]{1}[1-9]{9}$");
            Console.Write("Enter Mobile Number-");
            string mobilenumber = Console.ReadLine();
            Match match = regex.Match(mobilenumber);
            if (regex.IsMatch(mobilenumber))
            {
                MobileNumber = mobilenumber;
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number-");
                verifymobilenumber();
            }
        }
        private bool verifypassword1(string password)
        {
            Regex regex = new Regex("^[A-Za-z0-9!@#$%&*_-]{8,}$");
            bool result = regex.IsMatch(password);
            return result;
        }
        private bool verifypassword2(string password)
        {
            Regex regex = new Regex("^.*[A-Z]+.*$");
            bool result = regex.IsMatch(password);
            return result;
        }
        private bool verifypassword3(string password)
        {
            Regex regex = new Regex("^.*[0-9]+.*$");
            bool result = regex.IsMatch(password);
            return result;
        }
        private bool verifypassword4(string password)
        {
            Regex regex = new Regex("^.*[!@#$%&*_-]+.*$");
            bool result = regex.IsMatch(password);
            return result;
        }
        public void verifypassword()
        {
            Console.Write("Enter Password-");
            string password = Console.ReadLine();
            if (verifypassword1(password) && verifypassword2(password) && verifypassword3(password) && verifypassword4(password))
            {
                Password = password;
            }
            else
            {
                Console.WriteLine("Invalid Password-");
                Console.WriteLine("Password needs to have \n" +
                   "1. Minimum 8 characters\n" +
                   "2. At least one upper case character\n" +
                   "3. At least one numeric value" +
                   "4. At least one special character");
                verifypassword();
            }
        }
        public void VerifiedEmailList()
        { 
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");

            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("abc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");
            {
                Regex regex = new Regex("^[a-z0-9-+]+([.][a-z0-9+-]+)?@[a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
            }
            foreach (string email in emailList)
            {
                if (regex.IsMatch(email))
                    Console.WriteLine(email + "- Valid Email");
                else
                    Console.WriteLine(email + "- Invalid Email");
                foreach (string email in emailList)
                {
                    if (regex.IsMatch(email))
                        Console.WriteLine(email + "- VALID");
                    else
                        Console.WriteLine(email + "- INVALID");
                }
            }
        }
    }
}

