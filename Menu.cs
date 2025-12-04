using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp
{
    public class Menu
    {
        public void Run()
        {
            Console.WriteLine("1. Register as a guidian\n2. Login\n3. Leave\nChoose : ");
            string option = Console.ReadLine()!;

            if (option == "1")
            {
                Console.Write("Input Name : ");
                string name = Console.ReadLine()!;
                
            }

            else if (option == "2")
            {
                
            }

            else if (option == "3")
            {
                
            }

            else
            {
                
            }
        }
    }
}