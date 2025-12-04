using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMgtApp.Models.Entities;
using StudMgtApp.Repositories.Interfaces;

namespace StudentMgtApp.Services.Interfaces
{
    public interface IGuardianService
    {
        public RegisterGuardianResponse  CreateAccount(RegisterGuardianRequest registerGuardianRequest);
    }
}