using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student? GetByEmail(string email);
        Student? GetById(int id);
        int GetNextId();
        List<Student> GetAllStudent();
    }
}