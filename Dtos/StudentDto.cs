using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Dtos
{
    public class StudentDto
    {
        public int Id{ get; set; }
         public int GuardianId{ get; set; }
        public string Name{ get; set; } = default!;
        public int Age{get; set; }
        public string Class{ get; set; } = default!;

        public record RegisterStudentRequest(string Name, string Class);
        public record RegisterStudentResponse(int Id, string Name,int age,string GuardianName, string Class);
    }
}