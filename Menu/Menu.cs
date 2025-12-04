using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Menu
{
    public class Menu
    {
                public void Run()
        {
            Console.WriteLine("1. Register as a guidian\n2. Login\n3. Leave\nChoose : ");
            string option = Console.ReadLine()!;

            if (option == "1")
            {   
                
                Console.Write("Input Firstname : ");
                string name = Console.ReadLine()!;

                Console.Write("Input Firstname : ");
                string lastName = Console.ReadLine()!;
                
                Console.Write("Address : ");
                string address = Console.ReadLine()!;

                Console.Write("Phone : ");
                string phone = Console.ReadLine()!;

                Console.Write("Email : ");
                string email = Console.ReadLine()!;
                
                Console.Write("Password : ");
                string password = Console.ReadLine()!;
            }

            else if (option == "2")
            {
                Console.Write("Email : ");
                string email = Console.ReadLine()!;
                
                Console.Write("Password : ");
                string password = Console.ReadLine()!;
            }

            else if (option == "3")
            {
                Console.WriteLine("Thanks !");
            }

            else
            {
                Console.WriteLine("Invalid Input !");
                Run();
            }
        }
    }
}