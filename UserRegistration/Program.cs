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
            Console.WriteLine("First Name " + user.FirstName);
        }
    }
}
