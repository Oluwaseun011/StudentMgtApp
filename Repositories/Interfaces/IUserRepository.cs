using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        User? GetByEmail(string email);
        User? GetById(int id);
        int GetNextId();
        List<User> GetUsers();
    }
}