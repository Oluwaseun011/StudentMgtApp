using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Dtos;

namespace StudentMgtApp.Services.Interfaces
{
    public interface IStudentService
    {
        RegisterStudentResponse? RegisterStudent(RegisterStudentRequest request);
    }
}