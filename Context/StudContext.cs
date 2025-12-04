using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Models.Entities;

namespace StudMgtApp.Context
{
    public class StudContext
    {
        public static List<Guardian> guardians = new List<Guardian>();
        public static List<User> users = new List<User>();
        public static List<Student> students = new List<Student>();
    }
}