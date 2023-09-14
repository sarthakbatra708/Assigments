using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userid;
            string password;
            Console.WriteLine("Enter userid:");
            userid = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            if (userid == "Sarthak" && password == "hello123")
            {
                Console.WriteLine("Successfully Logged In");
            }
            else
            {
                Console.WriteLine("No user with the given credentials");
            }
            Console.ReadLine();



        }
    }
}
