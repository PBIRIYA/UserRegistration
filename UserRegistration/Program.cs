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
        }
    }
}
