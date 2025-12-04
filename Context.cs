using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace StudentMgtApp
{
    public class Context
    {
        public static List<Guardian> guardians = new List<Guardian>();
        public static List<User> users = new List<User>();
        public static List<Student> students = new List<Student>();
    }
}