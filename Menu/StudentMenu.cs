using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Menu
{
    public class StudentMenu
    {
        public void StartStudentMenu()
        {

        Console.WriteLine("Enter name of student ==>");
        string name = Console.ReadLine() ??"";

        Console.WriteLine("Enter age of student ==>");
        int age = int.Parse(Console.ReadLine() ??"");

        Console.WriteLine("Enter class of student ==>");
        int studClass = int.Parse(Console.ReadLine() ??"");

        }
       
    }
}