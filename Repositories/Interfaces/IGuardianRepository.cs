using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudMgtApp.Repositories.Interfaces
{
    public interface IGuardianRepository
    {
        int GenerateId();
        void AddToDb(Guardian guardian);
        Guardian? GetGuardian(int id);
        ICollection<Guardian> GetGuardians();
    }
}