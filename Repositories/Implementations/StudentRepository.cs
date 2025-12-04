using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Models.Entities;
using StudentMgtApp.Repositories.Interfaces;

namespace StudentMgtApp.Repositories.Implementations
{
    public class StudentRepository:IStudentRepository
    {
        void Add(Student student)
        {
            StudContext.students.Add(student);
        }
        Student? GetByEmail(string email)
        {
            foreach (var item in StudContext.students)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
        Student? GetById(int id)
        {
            foreach (var item in StudContext.students)
            {
                if(item.Email == id)
                {
                    return item;
                }
            }
            return null;
        }
        int GetNextId()
        {
            return StudContext.students.Count() + 1;
        }
        List<Student> GetAllStudent()
        {
            return StudContext.student;
        }
    }
}