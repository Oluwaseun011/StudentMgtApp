using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Dtos;
using StudentMgtApp.Models.Entities;

namespace StudentMgtApp.Services.Interfaces
{
    public interface IUserService
    {
        LoginResponse Login(LoginRequest login);
    }
}