using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Models.Entities;
using StudentMgtApp.Repositories.Interfaces;
using StudMgtApp.Context;
using StudMgtApp.Models.Enums;

namespace StudMgtApp.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            StudContext.users.Add(user);
        }

        public void AddCurrentUserToDb(string email)
        {
            StudContext.CurrentLoggedin = email;
        }

        public User? GetByEmail(string email)
        {
            foreach (var item in StudContext.users)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public User? GetById(int id)
        {
            return StudContext.users.Find(a => a.Id == id);
        }

        public string GetCurrentLoggedInUser()
        {
            return StudContext.CurrentLoggedin;

        }

        public int GetNextId()
        {
            return StudContext.users.Count + 1;
        }

        public List<User> GetUsers()
        {
            return StudContext.users;
        }
    }
}