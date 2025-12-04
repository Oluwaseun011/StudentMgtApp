using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Dtos
{
    public class NewStudentDto
    {
         public int Id{ get; set; }
         public int GuardianId{ get; set; }
        public string Name{ get; set; } = default!;
        public int Age{get; set; }
        public string Class{ get; set; } = default!;

        public record RegisterStudentRequest(string Name, string Class, int age);
        public record RegisterStudentResponse(int Id, string Name);
    }
}