using System;
namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcoming Users for Registration !");
            User user = new User();
            user.verifyfirstName();
            user.verifylastName();
            Console.WriteLine("Name- " + user.FirstName + user.LastName);
            user.verifyemail();
            Console.WriteLine("Email Address-" + user.Email);
            user.verifymobilenumber();
            Console.WriteLine("Mobile Number-" + user.MobileNumber);
            user.verifypassword();
            Console.WriteLine("Password-" + user.Password);
        }
    }
}
